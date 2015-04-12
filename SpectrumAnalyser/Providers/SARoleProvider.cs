using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.Helpers;
using System.Web.WebPages;
using Microsoft.Internal.Web.Utils;
using SpectrumAnalyser.Models;
using SpectrumAnalyser.Models.BD;

namespace SpectrumAnalyser.Providers
{
    public class SARoleProvider : RoleProvider
    {

        //возвращает роль пользователя
        public override string[] GetRolesForUser(string login)
        {
            string[] role = new string[] { };
            using (EntityDataModel db = new EntityDataModel())
            {
                try
                {
                    // Получаем пользователя
                    tbl_1_User user = (from u in db.tbl_1_User
                                       where u.Login == login
                                       select u).FirstOrDefault();
                    if (user != null)
                    {
                        // получаем роль
                        tbl_2_Roles userRole = db.tbl_2_Roles.Find(user.RoleId);

                        if (userRole != null)
                        {
                            role = new string[] { userRole.RoleName };
                        }
                    }
                }
                catch
                {
                    role = new string[] { };
                }
            }
            return role;
        }

        public override void CreateRole(string roleName)
        {
            tbl_2_Roles newRole = new tbl_2_Roles() { RoleName = roleName };
            EntityDataModel db = new EntityDataModel();
            db.tbl_2_Roles.Add(newRole);
            db.SaveChanges();
        }

        //показывает, связан ли пользователь с данной ролью
        public override bool IsUserInRole(string username, string roleName)
        {
            bool outputResult = false;
            // Находим пользователя
            using (EntityDataModel db = new EntityDataModel())
            {
                try
                {
                    // Получаем пользователя
                    tbl_1_User user = (from u in db.tbl_1_User
                                       where u.Login == username
                                       select u).FirstOrDefault();
                    if (user != null)
                    {
                        // получаем роль
                        tbl_2_Roles userRole = db.tbl_2_Roles.Find(user.RoleId);

                        //сравниваем
                        if (userRole != null && userRole.RoleName == roleName)
                        {
                            outputResult = true;
                        }
                    }
                }
                catch
                {
                    outputResult = false;
                }
            }
            return outputResult;
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        //public override void CreateRole(string roleName)
        //{
        //    throw new NotImplementedException();
        //}

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}