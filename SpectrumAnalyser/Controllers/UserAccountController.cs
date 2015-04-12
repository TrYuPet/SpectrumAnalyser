using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using SpectrumAnalyser.Models;
using SpectrumAnalyser.Models.BD;
using WebMatrix.WebData;
using SpectrumAnalyser.Filters;
using Microsoft.Web.WebPages.OAuth;
using System.Transactions;

namespace SpectrumAnalyser.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class UserAccountController : Controller
    {
        private EntityDataModel db = new EntityDataModel();
        //
        // GET: /Account/Profile

        [AllowAnonymous]
        [Authorize(Roles = "Administrator, Moderator, User")]
        public ActionResult ProfileUser(string returnUrl)
        {
            int userId = WebSecurity.CurrentUserId;
            tbl_1_User user = db.tbl_1_User.Where(p => p.UserId == userId).FirstOrDefault();
            var spisok = db.tbl_1_User.Where(r => r.UserId == userId);
            return View(spisok.ToList());
        }

       

#region Списки пользователей

        // отображение списка пользователей
        [Authorize(Roles = "Administrator, Moderator")]
        [HttpGet]
        public ActionResult ViewListUser()
        {
            var users = db.tbl_1_User.Include(u => u.tbl_2_Roles).ToList();

            List<tbl_2_Roles> roles = db.tbl_2_Roles.ToList();
            roles.Insert(0, new tbl_2_Roles { RoleName = "Все", RoleId = 0 });
            ViewBag.tbl_2_Roles = new SelectList(roles, "RoleId", "RoleName");

            return View(users);
        }

        // поиск пользователей статусу
        [HttpPost]
        [Authorize(Roles = "Administrator, Moderator")]
        public ActionResult ViewListUser(int role)
        {
            IEnumerable<tbl_1_User> allUsers = null;
            if (role == 0)
            {
                return RedirectToAction("ViewListUser");
            }
            else if (role != 0)
                 
            {
                allUsers = from user in db.tbl_1_User.Include(u => u.tbl_2_Roles)
                           where user.RoleId == role
                           select user;
            }
            else
            {
                allUsers = from user in db.tbl_1_User.Include(u => u.tbl_2_Roles)
                           where user.RoleId == role
                           select user;
            }

            List<tbl_2_Roles> roles = db.tbl_2_Roles.ToList();
            roles.Insert(0, new tbl_2_Roles { RoleName = "Все", RoleId = 0 });
            ViewBag.tbl_2_Roles = new SelectList(roles, "RoleId", "RoleName");

            return View(allUsers.ToList());
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult EditListUser(int id)
        {
            tbl_1_User user = db.tbl_1_User.Find(id);
            SelectList roles = new SelectList(db.tbl_2_Roles, "RoleId", "RoleName", user.RoleId);
            ViewBag.tbl_2_Roles = roles;

            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult EditListUser(tbl_1_User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewListUser");
            }

            SelectList roles = new SelectList(db.tbl_2_Roles, "RoleId", "RoleName");
            ViewBag.tbl_2_Roles = roles;

            return View(user);
        }
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteListUser(int id)
        {
            tbl_1_User user = db.tbl_1_User.Find(id);
            db.tbl_1_User.Remove(user);
            db.SaveChanges();
            return RedirectToAction("ViewListUser");
        }

        #endregion

#region Создание нового пользователя через админа
        // При создании нового пользователя передаем в представление список ролей
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateNewUser()
        {
            SelectList roles = new SelectList(db.tbl_2_Roles, "RoleId", "RoleName");
            ViewBag.tbl_2_Roles = roles;
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateNewUser(tbl_1_User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.tbl_1_User.Add(user);
                    db.SaveChanges();
                    //return RedirectToAction("ViewListUser");
                    return RedirectToAction("AddInfOrganization", "UserAccount");

                }

                catch (MembershipCreateUserException e)
                { 
                   ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                }
            }

            SelectList roles = new SelectList(db.tbl_2_Roles, "RoleId", "RoleName");
            ViewBag.tbl_2_Roles = roles;
            return View(user);
        }

        #endregion

#region Авторизация и аутентификация пользователя
        //
        // GET: /Account/Login

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid && WebSecurity.Login(model.Login, model.Password, persistCookie: model.RememberMe))
            {
                return RedirectToLocal(returnUrl);
            }

            // Появление этого сообщения означает наличие ошибки; повторное отображение формы
            ModelState.AddModelError("", "Имя пользователя или пароль указаны неверно.");
            return View(model);
        }

        //
        // POST: /Account/LogOff

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            //WebSecurity.Logout();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register

        [AllowAnonymous]
        [Authorize(Roles = "User")]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [Authorize(Roles = "User")]
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userInfo = new
                    {
                        UserFirstName = model.UserFirstName,
                        UserLastName = model.UserLastName,
                        UserMiddleName = model.UserMiddleName,
                        UserEmail = model.UserEmail,
                        UserPhoneNumber = model.UserPhoneNumber,
                        UserMobilePhoneNumber = model.UserMobilePhoneNumber,
                        
                    };

                    WebSecurity.CreateUserAndAccount(model.Login, model.Password, userInfo);
                    WebSecurity.Login(model.Login, model.Password);                        
                    return RedirectToAction("AddInfCity", "UserAccount");
                    //return RedirectToAction("Index", "Home");
                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                }
            }
            // Появление этого сообщения означает наличие ошибки; повторное отображение формы
            return View(model);
        }

#endregion

#region добавление инфы по пользователю при регистрации

        //
        // GET: /UserAccount/AddInfOrganization

        [AllowAnonymous]
        public ActionResult AddInfOrganization()
        {
            return View();
        }

        //
        // POST: /UserAccount/AddInfOrganization
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddInfOrganization(tbl_5_Organization tbl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                   
                    db.tbl_5_Organization.Add(tbl);
                    db.SaveChanges();
                    int idOrganization = tbl.OrganizationId;

                    SaveOrganization(idOrganization);
                    return RedirectToAction("ProfileUser");
                    
                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                }
            }
            // Появление этого сообщения означает наличие ошибки; повторное отображение формы
            return View(tbl);
        }

        
         //GET: /UserAccount/AddInfCity

        [AllowAnonymous]
        public ActionResult AddInfCity()
        {
            return View();
        }

        //
        // POST: /UserAccount/AddInfCity
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult AddInfCity(tbl_6_City tblSity)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    db.tbl_6_City.Add(tblSity);
                    db.SaveChanges();

                    int idCity = tblSity.CityId;

                    SaveCity(idCity);

                    return RedirectToAction("AddInfOrganization", "UserAccount");

                }
                catch (MembershipCreateUserException e)
                {
                    ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
                }
            }
            // Появление этого сообщения означает наличие ошибки; повторное отображение формы
            return View(tblSity);
        }

        // сохраняем инфу по зарегистрированному пользователю
        private void SaveOrganization(int idOrganization)
        {
            int userId = WebSecurity.CurrentUserId;
            tbl_1_User modified_user = db.tbl_1_User.Where(p => p.UserId == userId).FirstOrDefault();
            modified_user.OrganizationId = idOrganization;
            db.SaveChanges();
        }

        private void SaveCity(int idCity)
        {
            int userId = WebSecurity.CurrentUserId;
            tbl_1_User modified_user = db.tbl_1_User.Where(p => p.UserId == userId).FirstOrDefault();
            if (modified_user.RoleId == null)
            {
                tbl_2_Roles roles = db.tbl_2_Roles.FirstOrDefault(p => p.RoleName == "User");
                modified_user.RoleId = roles.RoleId;
            }
            else
            {
                modified_user.CityId = idCity;
            }
            
            db.SaveChanges();
        }


        #endregion

#region редактирование профиля

        // изменение личной информации
        [HttpGet]
        [Authorize(Roles = "Administrator, Moderator, User")]
        public ActionResult EditProfileUser()
        {
            int userId = WebSecurity.CurrentUserId;
            tbl_1_User user = db.tbl_1_User.Find(userId);
            if (user == null)
            {
                return HttpNotFound();
            }
            SelectList roles = new SelectList(db.tbl_2_Roles, "RoleId", "RoleName", user.RoleId);
            ViewBag.tbl_2_Roles = roles;

            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator, Moderator, User")]
        public ActionResult EditProfileUser(tbl_1_User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ProfileUser");
            }

            SelectList roles = new SelectList(db.tbl_2_Roles, "RoleId", "RoleName");
            ViewBag.tbl_2_Roles = roles;

            return View(user);
        }

        // изменение  информации о работе
        [HttpGet]
        [Authorize(Roles = "Administrator, Moderator, User")]
        public ActionResult EditProfileCity()
        {
            int userId = WebSecurity.CurrentUserId;
            tbl_1_User user = db.tbl_1_User.Where(p => p.UserId == userId).FirstOrDefault();

            if (user.CityId == null)
            {
                AddInfCity();
                return RedirectToAction("ProfileUser");
            }
            else
            {
                var id = user.CityId;
                tbl_6_City city = db.tbl_6_City.Where(p => p.CityId == id).FirstOrDefault();

                return View(city);
            }
           
        }

        [HttpPost]
        [Authorize(Roles = "Administrator, Moderator, User")]
        public ActionResult EditProfileCity(tbl_6_City city)
        {
            if (ModelState.IsValid)
            {
                db.Entry(city).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ProfileUser");
            }

            return View(city);
        }

        // изменение информации о месте жительства

        [HttpGet]
        [Authorize(Roles = "Administrator, Moderator, User")]
        public ActionResult EditProfileOrganization()
        {
            int userId = WebSecurity.CurrentUserId;
            tbl_1_User user = db.tbl_1_User.Where(p => p.UserId == userId).FirstOrDefault();

            if (user.OrganizationId == null)
            {
                return RedirectToAction("AddInfOrganization", "UserAccount");
            }
            else
            {
                var id = user.OrganizationId;
                tbl_5_Organization organization = db.tbl_5_Organization.Where(p => p.OrganizationId == id).FirstOrDefault();
                return View(organization);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Administrator, Moderator, User")]
        public ActionResult EditProfileOrganization(tbl_5_Organization organization)
        {
            if (ModelState.IsValid)
            {
                db.Entry(organization).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ProfileUser");
            }

            return View(organization);
        }

#endregion

#region ПАРОЛЬ
        //
        // POST: /Account/Disassociate

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Disassociate(string provider, string providerUserId)
        {
            string ownerAccount = OAuthWebSecurity.GetUserName(provider, providerUserId);
            ManageMessageId? message = null;

            // Удалять связь учетной записи, только если текущий пользователь — ее владелец
            if (ownerAccount == User.Identity.Name)
            {
                // Транзакция используется, чтобы помешать пользователю удалить учетные данные последнего входа
                using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.Serializable }))
                {
                    bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
                    if (hasLocalAccount || OAuthWebSecurity.GetAccountsFromUserName(User.Identity.Name).Count > 1)
                    {
                        OAuthWebSecurity.DeleteAccount(provider, providerUserId);
                        scope.Complete();
                        message = ManageMessageId.RemoveLoginSuccess;
                    }
                }
            }

            return RedirectToAction("Manage", new { Message = message });
        }

        //
        // GET: /Account/Manage

        public ActionResult Manage(ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageMessageId.ChangePasswordSuccess ? "Пароль изменен."
                : message == ManageMessageId.SetPasswordSuccess ? "Пароль задан."
                : message == ManageMessageId.RemoveLoginSuccess ? "Внешняя учетная запись удалена."
                : "";
            ViewBag.HasLocalPassword = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
            ViewBag.ReturnUrl = Url.Action("Manage");
            return View();
        }

        //
        // POST: /Account/Manage

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Manage(LocalPasswordModel model)
        {
            bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
            ViewBag.HasLocalPassword = hasLocalAccount;
            ViewBag.ReturnUrl = Url.Action("Manage");
            if (hasLocalAccount)
            {
                if (ModelState.IsValid)
                {
                    // В ряде случаев при сбое ChangePassword породит исключение, а не вернет false.
                    bool changePasswordSucceeded;
                    try
                    {
                        changePasswordSucceeded = WebSecurity.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword);
                    }
                    catch (Exception)
                    {
                        changePasswordSucceeded = false;
                    }

                    if (changePasswordSucceeded)
                    {
                        return RedirectToAction("Manage", new { Message = ManageMessageId.ChangePasswordSuccess });
                    }
                    else
                    {
                        ModelState.AddModelError("", "Неправильный текущий пароль или недопустимый новый пароль.");
                    }
                }
            }
            else
            {
                // У пользователя нет локального пароля, уберите все ошибки проверки, вызванные отсутствующим
                // полем OldPassword
                ModelState state = ModelState["OldPassword"];
                if (state != null)
                {
                    state.Errors.Clear();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        WebSecurity.CreateAccount(User.Identity.Name, model.NewPassword);
                        return RedirectToAction("Manage", new { Message = ManageMessageId.SetPasswordSuccess });
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("", e);
                    }
                }
            }

            // Появление этого сообщения означает наличие ошибки; повторное отображение формы
            return View(model);
        }
#endregion

#region Вспомогательные методы
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public enum ManageMessageId
        {
            ChangePasswordSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
        }

        internal class ExternalLoginResult : ActionResult
        {
            public ExternalLoginResult(string provider, string returnUrl)
            {
                Provider = provider;
                ReturnUrl = returnUrl;
            }

            public string Provider { get; private set; }
            public string ReturnUrl { get; private set; }

            public override void ExecuteResult(ControllerContext context)
            {
                OAuthWebSecurity.RequestAuthentication(Provider, ReturnUrl);
            }
        }

        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // Полный список кодов состояния см. по адресу http://go.microsoft.com/fwlink/?LinkID=177550
            //.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Имя пользователя уже существует. Введите другое имя пользователя.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "Имя пользователя для данного адреса электронной почты уже существует. Введите другой адрес электронной почты.";

                case MembershipCreateStatus.InvalidPassword:
                    return "Указан недопустимый пароль. Введите допустимое значение пароля.";

                case MembershipCreateStatus.InvalidEmail:
                    return "Указан недопустимый адрес электронной почты. Проверьте значение и повторите попытку.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "Указан недопустимый ответ на вопрос для восстановления пароля. Проверьте значение и повторите попытку.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "Указан недопустимый вопрос для восстановления пароля. Проверьте значение и повторите попытку.";

                case MembershipCreateStatus.InvalidUserName:
                    return "Указано недопустимое имя пользователя. Проверьте значение и повторите попытку.";

                case MembershipCreateStatus.ProviderError:
                    return "Поставщик проверки подлинности вернул ошибку. Проверьте введенное значение и повторите попытку. Если проблему устранить не удастся, обратитесь к системному администратору.";

                case MembershipCreateStatus.UserRejected:
                    return "Запрос создания пользователя был отменен. Проверьте введенное значение и повторите попытку. Если проблему устранить не удастся, обратитесь к системному администратору.";

                default:
                    return "Произошла неизвестная ошибка. Проверьте введенное значение и повторите попытку. Если проблему устранить не удастся, обратитесь к системному администратору.";
            }
        }
        #endregion
    }
}
