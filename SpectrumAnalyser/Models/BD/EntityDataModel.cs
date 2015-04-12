namespace SpectrumAnalyser.Models.BD
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=EntityDataModel")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_1_User> tbl_1_User { get; set; }
        public virtual DbSet<tbl_10_ChemicalElement> tbl_10_ChemicalElement { get; set; }
        public virtual DbSet<tbl_11_AuthorPictures> tbl_11_AuthorPictures { get; set; }
        public virtual DbSet<tbl_12_GeografyPlace> tbl_12_GeografyPlace { get; set; }
        public virtual DbSet<tbl_13_HistoryPeriod> tbl_13_HistoryPeriod { get; set; }
        public virtual DbSet<tbl_14_WorksOfArt> tbl_14_WorksOfArt { get; set; }
        public virtual DbSet<tbl_15_Country> tbl_15_Country { get; set; }
        public virtual DbSet<tbl_17_PassportResearch> tbl_17_PassportResearch { get; set; }
        public virtual DbSet<tbl_18_RemarkOfDate> tbl_18_RemarkOfDate { get; set; }
        public virtual DbSet<tbl_19_DateOfCreated> tbl_19_DateOfCreated { get; set; }
        public virtual DbSet<tbl_2_Roles> tbl_2_Roles { get; set; }
        public virtual DbSet<tbl_20_InstrumentalMethods> tbl_20_InstrumentalMethods { get; set; }
        public virtual DbSet<tbl_21_SpectrumLine> tbl_21_SpectrumLine { get; set; }
        public virtual DbSet<tbl_22_Spektr> tbl_22_Spektr { get; set; }
        public virtual DbSet<tbl_23_StatesOfMatter_ChemicalElement> tbl_23_StatesOfMatter_ChemicalElement { get; set; }
        public virtual DbSet<tbl_24_CrystalStructures_ChemicalElement> tbl_24_CrystalStructures_ChemicalElement { get; set; }
        public virtual DbSet<tbl_25_Isotop_ChemicalElement> tbl_25_Isotop_ChemicalElement { get; set; }
        public virtual DbSet<tbl_26_Pigments> tbl_26_Pigments { get; set; }
        public virtual DbSet<tbl_27_Group> tbl_27_Group { get; set; }
        public virtual DbSet<tbl_28_Works_of_Art_objects> tbl_28_Works_of_Art_objects { get; set; }
        public virtual DbSet<tbl_29_Icons_objects> tbl_29_Icons_objects { get; set; }
        public virtual DbSet<tbl_3_Privileges> tbl_3_Privileges { get; set; }
        public virtual DbSet<tbl_31_ResearchObjectsCategory> tbl_31_ResearchObjectsCategory { get; set; }
        public virtual DbSet<tbl_32_PlotFocus> tbl_32_PlotFocus { get; set; }
        public virtual DbSet<tbl_33_ObjectsPhoto> tbl_33_ObjectsPhoto { get; set; }
        public virtual DbSet<tbl_34_LibrarySpectrumLines> tbl_34_LibrarySpectrumLines { get; set; }
        public virtual DbSet<tbl_36_ResearchObjectType> tbl_36_ResearchObjectType { get; set; }
        public virtual DbSet<tbl_37_ElementAtom> tbl_37_ElementAtom { get; set; }
        public virtual DbSet<tbl_38_Isotope_ElementAtom> tbl_38_Isotope_ElementAtom { get; set; }
        public virtual DbSet<tbl_39_CrystalStructures_Element_Atom> tbl_39_CrystalStructures_Element_Atom { get; set; }
        public virtual DbSet<tbl_40_SpektrumMeasurement> tbl_40_SpektrumMeasurement { get; set; }
        public virtual DbSet<tbl_41_Content> tbl_41_Content { get; set; }
        public virtual DbSet<tbl_42_Ions> tbl_42_Ions { get; set; }
        public virtual DbSet<tbl_43_StatesOfMatter_Element_Atom> tbl_43_StatesOfMatter_Element_Atom { get; set; }
        public virtual DbSet<tbl_45_FingerPrint> tbl_45_FingerPrint { get; set; }
        public virtual DbSet<tbl_5_Organization> tbl_5_Organization { get; set; }
        public virtual DbSet<tbl_6_City> tbl_6_City { get; set; }
        public virtual DbSet<tbl_9_SpektrumLines_ChemicalElement> tbl_9_SpektrumLines_ChemicalElement { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_1_User>()
                .Property(e => e.UserFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_1_User>()
                .Property(e => e.UserLastName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_1_User>()
                .Property(e => e.UserMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_1_User>()
                .Property(e => e.UserEmail)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_1_User>()
                .Property(e => e.UserPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_1_User>()
                .Property(e => e.UserMobilePhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_1_User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_1_User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_1_User>()
                .HasMany(e => e.tbl_28_Works_of_Art_objects)
                .WithRequired(e => e.tbl_1_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_1_User>()
                .HasMany(e => e.tbl_29_Icons_objects)
                .WithRequired(e => e.tbl_1_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_1_User>()
                .HasMany(e => e.tbl_32_PlotFocus)
                .WithRequired(e => e.tbl_1_User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_10_ChemicalElement>()
                .Property(e => e.ChemicalElementDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_10_ChemicalElement>()
                .HasMany(e => e.tbl_22_Spektr)
                .WithRequired(e => e.tbl_10_ChemicalElement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_10_ChemicalElement>()
                .HasMany(e => e.tbl_25_Isotop_ChemicalElement)
                .WithRequired(e => e.tbl_10_ChemicalElement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_10_ChemicalElement>()
                .HasMany(e => e.tbl_23_StatesOfMatter_ChemicalElement)
                .WithMany(e => e.tbl_10_ChemicalElement)
                .Map(m => m.ToTable("Has_10_23").MapLeftKey("ChemicalElementId").MapRightKey("StatesOfMatterId"));

            modelBuilder.Entity<tbl_11_AuthorPictures>()
                .Property(e => e.AuthorFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_11_AuthorPictures>()
                .Property(e => e.AuthorLastName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_11_AuthorPictures>()
                .Property(e => e.AuthorMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_11_AuthorPictures>()
                .Property(e => e.AuthorBiography)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_12_GeografyPlace>()
                .Property(e => e.GeografyPlaceCity)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_12_GeografyPlace>()
                .Property(e => e.Administrative_District_1)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_12_GeografyPlace>()
                .Property(e => e.Administrative_District_2)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_12_GeografyPlace>()
                .Property(e => e.Administrative_District_3)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_13_HistoryPeriod>()
                .Property(e => e.HistoryPeriodName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_13_HistoryPeriod>()
                .Property(e => e.HistoryPeriodIdDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_13_HistoryPeriod>()
                .HasMany(e => e.tbl_11_AuthorPictures)
                .WithRequired(e => e.tbl_13_HistoryPeriod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_14_WorksOfArt>()
                .Property(e => e.PictureName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_14_WorksOfArt>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_14_WorksOfArt>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_14_WorksOfArt>()
                .Property(e => e.Technique)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_14_WorksOfArt>()
                .Property(e => e.PurposeOfResearch)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_14_WorksOfArt>()
                .Property(e => e.Conclusion)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_14_WorksOfArt>()
                .Property(e => e.StatusWorks)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_14_WorksOfArt>()
                .HasMany(e => e.tbl_17_PassportResearch)
                .WithRequired(e => e.tbl_14_WorksOfArt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_15_Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_15_Country>()
                .Property(e => e.CountryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_15_Country>()
                .HasMany(e => e.tbl_12_GeografyPlace)
                .WithRequired(e => e.tbl_15_Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_17_PassportResearch>()
                .Property(e => e.Conclusion_the_method)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_18_RemarkOfDate>()
                .Property(e => e.RemarkOfDateCreate)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_2_Roles>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_2_Roles>()
                .HasMany(e => e.tbl_1_User)
                .WithRequired(e => e.tbl_2_Roles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_20_InstrumentalMethods>()
                .Property(e => e.InstrumentalMethodsName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_20_InstrumentalMethods>()
                .Property(e => e.InstrumentalMethodsDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_21_SpectrumLine>()
                .Property(e => e.SpectrumLinePersonName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_21_SpectrumLine>()
                .Property(e => e.OtherOptions)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_21_SpectrumLine>()
                .HasMany(e => e.tbl_22_Spektr)
                .WithRequired(e => e.tbl_21_SpectrumLine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_22_Spektr>()
                .Property(e => e.LineDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_22_Spektr>()
                .Property(e => e.SpektrsBase)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_22_Spektr>()
                .HasMany(e => e.tbl_32_PlotFocus)
                .WithMany(e => e.tbl_22_Spektr)
                .Map(m => m.ToTable("include_22_32").MapLeftKey("SpektrId").MapRightKey("PlotFocusId"));

            modelBuilder.Entity<tbl_23_StatesOfMatter_ChemicalElement>()
                .Property(e => e.StatesOfMatterIdDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_24_CrystalStructures_ChemicalElement>()
                .Property(e => e.CrystalStructureDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_24_CrystalStructures_ChemicalElement>()
                .HasMany(e => e.tbl_10_ChemicalElement)
                .WithRequired(e => e.tbl_24_CrystalStructures_ChemicalElement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_26_Pigments>()
                .Property(e => e.PigmentColor)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_26_Pigments>()
                .Property(e => e.PigmentChemicalFormula)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_26_Pigments>()
                .Property(e => e.PigmentWhereUsed)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_26_Pigments>()
                .Property(e => e.PigmentLiterature)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_27_Group>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_28_Works_of_Art_objects>()
                .Property(e => e.ResearchObjectName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_28_Works_of_Art_objects>()
                .HasMany(e => e.tbl_32_PlotFocus)
                .WithRequired(e => e.tbl_28_Works_of_Art_objects)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_29_Icons_objects>()
                .Property(e => e.ResearchObjectName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_29_Icons_objects>()
                .HasMany(e => e.tbl_32_PlotFocus)
                .WithRequired(e => e.tbl_29_Icons_objects)
                .HasForeignKey(e => e.tbl_ResearchObjectId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_29_Icons_objects>()
                .HasMany(e => e.tbl_33_ObjectsPhoto)
                .WithOptional(e => e.tbl_29_Icons_objects)
                .HasForeignKey(e => e.tbl_ResearchObjectId);

            modelBuilder.Entity<tbl_3_Privileges>()
                .Property(e => e.PrivilegeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_3_Privileges>()
                .HasMany(e => e.tbl_1_User)
                .WithRequired(e => e.tbl_3_Privileges)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_31_ResearchObjectsCategory>()
                .Property(e => e.ResearchObjectsCategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_31_ResearchObjectsCategory>()
                .Property(e => e.ResearchObjectsCategoryValue)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_32_PlotFocus>()
                .HasMany(e => e.tbl_45_FingerPrint1)
                .WithOptional(e => e.tbl_32_PlotFocus1)
                .HasForeignKey(e => e.PlotFocusId);

            modelBuilder.Entity<tbl_32_PlotFocus>()
                .HasMany(e => e.tbl_9_SpektrumLines_ChemicalElement)
                .WithRequired(e => e.tbl_32_PlotFocus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_34_LibrarySpectrumLines>()
                .Property(e => e.LibraryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_34_LibrarySpectrumLines>()
                .Property(e => e.LibraryCooment)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_34_LibrarySpectrumLines>()
                .HasMany(e => e.tbl_21_SpectrumLine)
                .WithRequired(e => e.tbl_34_LibrarySpectrumLines)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_36_ResearchObjectType>()
                .Property(e => e.ResearchObjectTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_36_ResearchObjectType>()
                .HasMany(e => e.tbl_28_Works_of_Art_objects)
                .WithRequired(e => e.tbl_36_ResearchObjectType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_36_ResearchObjectType>()
                .HasMany(e => e.tbl_29_Icons_objects)
                .WithRequired(e => e.tbl_36_ResearchObjectType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_37_ElementAtom>()
                .Property(e => e.ElementAtomDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_37_ElementAtom>()
                .Property(e => e.SymbolAtom)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_37_ElementAtom>()
                .Property(e => e.AtomRussianName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_37_ElementAtom>()
                .Property(e => e.AtomEnglishName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_37_ElementAtom>()
                .Property(e => e.AtomDescriptionDiscoveries)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_37_ElementAtom>()
                .HasMany(e => e.tbl_38_Isotope_ElementAtom)
                .WithRequired(e => e.tbl_37_ElementAtom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_37_ElementAtom>()
                .HasMany(e => e.tbl_41_Content)
                .WithRequired(e => e.tbl_37_ElementAtom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_37_ElementAtom>()
                .HasMany(e => e.tbl_42_Ions)
                .WithRequired(e => e.tbl_37_ElementAtom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_38_Isotope_ElementAtom>()
                .Property(e => e.IsotopeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_38_Isotope_ElementAtom>()
                .Property(e => e.IsotopeRussionName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_38_Isotope_ElementAtom>()
                .Property(e => e.IsotopeEnglishName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_38_Isotope_ElementAtom>()
                .Property(e => e.IsotopeDescriptionDiscovery)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_39_CrystalStructures_Element_Atom>()
                .Property(e => e.CrystalStructuresName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_39_CrystalStructures_Element_Atom>()
                .Property(e => e.CrystalStructuresDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_39_CrystalStructures_Element_Atom>()
                .Property(e => e.CrystalStructuresSymbol)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbl_39_CrystalStructures_Element_Atom>()
                .HasMany(e => e.tbl_37_ElementAtom)
                .WithRequired(e => e.tbl_39_CrystalStructures_Element_Atom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_40_SpektrumMeasurement>()
                .Property(e => e.SpektrumMeasurementName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_40_SpektrumMeasurement>()
                .Property(e => e.SpektrumMeasurementIdDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_40_SpektrumMeasurement>()
                .Property(e => e.SpektrumMeasurementPlace)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_40_SpektrumMeasurement>()
                .HasMany(e => e.tbl_41_Content)
                .WithRequired(e => e.tbl_40_SpektrumMeasurement)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_41_Content>()
                .Property(e => e.ContentName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_42_Ions>()
                .Property(e => e.IonDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_42_Ions>()
                .Property(e => e.IonRussianName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_42_Ions>()
                .Property(e => e.IonEnglishName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_42_Ions>()
                .Property(e => e.IonCharge)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_43_StatesOfMatter_Element_Atom>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_43_StatesOfMatter_Element_Atom>()
                .Property(e => e.StateSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_43_StatesOfMatter_Element_Atom>()
                .Property(e => e.StateRussianName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_43_StatesOfMatter_Element_Atom>()
                .Property(e => e.StateEnglishName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_43_StatesOfMatter_Element_Atom>()
                .Property(e => e.StateDescruprionDiscoveries)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_43_StatesOfMatter_Element_Atom>()
                .HasMany(e => e.tbl_41_Content)
                .WithRequired(e => e.tbl_43_StatesOfMatter_Element_Atom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_45_FingerPrint>()
                .HasMany(e => e.tbl_32_PlotFocus)
                .WithOptional(e => e.tbl_45_FingerPrint)
                .HasForeignKey(e => e.FingerPrintId);

            modelBuilder.Entity<tbl_5_Organization>()
                .Property(e => e.OrganizationStatus)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_5_Organization>()
                .Property(e => e.OrganizationType)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_5_Organization>()
                .Property(e => e.OrganizationDescription)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_5_Organization>()
                .Property(e => e.OrganizationAdress)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_5_Organization>()
                .Property(e => e.OrganizationEmail)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_5_Organization>()
                .Property(e => e.OrganizationPhoneNumbe)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_5_Organization>()
                .HasMany(e => e.tbl_1_User)
                .WithRequired(e => e.tbl_5_Organization)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_6_City>()
                .Property(e => e.UserCity)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_6_City>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_6_City>()
                .Property(e => e.AdministrativeDevision)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_6_City>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_6_City>()
                .HasMany(e => e.tbl_1_User)
                .WithRequired(e => e.tbl_6_City)
                .WillCascadeOnDelete(false);
        }
    }
}
