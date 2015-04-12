/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     12.04.15 12:58:35                            */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Has_10_23') and o.name = 'FK_HAS_10_2_HAS_10_23_TBL_10_C')
alter table Has_10_23
   drop constraint FK_HAS_10_2_HAS_10_23_TBL_10_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Has_10_23') and o.name = 'FK_HAS_10_2_HAS_10_24_TBL_23_S')
alter table Has_10_23
   drop constraint FK_HAS_10_2_HAS_10_24_TBL_23_S
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('include_22_32') and o.name = 'FK_INCLUDE__INCLUDE_2_TBL_22_S')
alter table include_22_32
   drop constraint FK_INCLUDE__INCLUDE_2_TBL_22_S
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('include_22_32') and o.name = 'FK_INCLUDE__INCLUDE_2_TBL_32_P')
alter table include_22_32
   drop constraint FK_INCLUDE__INCLUDE_2_TBL_32_P
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_10_ChemicalElement') and o.name = 'FK_TBL_10_C_HAS_24_10_TBL_24_C')
alter table tbl_10_ChemicalElement
   drop constraint FK_TBL_10_C_HAS_24_10_TBL_24_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_11_AuthorPictures') and o.name = 'FK_TBL_11_A_CONTAINS__TBL_12_G')
alter table tbl_11_AuthorPictures
   drop constraint FK_TBL_11_A_CONTAINS__TBL_12_G
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_11_AuthorPictures') and o.name = 'FK_TBL_11_A_INCLUDE_1_TBL_13_H')
alter table tbl_11_AuthorPictures
   drop constraint FK_TBL_11_A_INCLUDE_1_TBL_13_H
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_12_GeografyPlace') and o.name = 'FK_TBL_12_G_LOCATED_1_TBL_15_C')
alter table tbl_12_GeografyPlace
   drop constraint FK_TBL_12_G_LOCATED_1_TBL_15_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_14_WorksOfArt') and o.name = 'FK_TBL_14_W_HAS_11_14_TBL_11_A')
alter table tbl_14_WorksOfArt
   drop constraint FK_TBL_14_W_HAS_11_14_TBL_11_A
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_17_PassportResearch') and o.name = 'FK_TBL_17_P_HAS_14_17_TBL_14_W')
alter table tbl_17_PassportResearch
   drop constraint FK_TBL_17_P_HAS_14_17_TBL_14_W
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_17_PassportResearch') and o.name = 'FK_TBL_17_P_INCLUDE_2_TBL_20_I')
alter table tbl_17_PassportResearch
   drop constraint FK_TBL_17_P_INCLUDE_2_TBL_20_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_18_RemarkOfDate') and o.name = 'FK_TBL_18_R_CONTAIN_1_TBL_14_W')
alter table tbl_18_RemarkOfDate
   drop constraint FK_TBL_18_R_CONTAIN_1_TBL_14_W
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_18_RemarkOfDate') and o.name = 'FK_TBL_18_R_HAVE_19_1_TBL_19_D')
alter table tbl_18_RemarkOfDate
   drop constraint FK_TBL_18_R_HAVE_19_1_TBL_19_D
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_1_User') and o.name = 'FK_TBL_1_US_BELONGS_5_TBL_5_OR')
alter table tbl_1_User
   drop constraint FK_TBL_1_US_BELONGS_5_TBL_5_OR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_1_User') and o.name = 'FK_TBL_1_US_HAS_2_1_TBL_2_RO')
alter table tbl_1_User
   drop constraint FK_TBL_1_US_HAS_2_1_TBL_2_RO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_1_User') and o.name = 'FK_TBL_1_US_HAS_3_1_TBL_3_PR')
alter table tbl_1_User
   drop constraint FK_TBL_1_US_HAS_3_1_TBL_3_PR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_1_User') and o.name = 'FK_TBL_1_US_LIVE_6_4_TBL_6_CI')
alter table tbl_1_User
   drop constraint FK_TBL_1_US_LIVE_6_4_TBL_6_CI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_21_SpectrumLine') and o.name = 'FK_TBL_21_S_CONTAINS__TBL_34_L')
alter table tbl_21_SpectrumLine
   drop constraint FK_TBL_21_S_CONTAINS__TBL_34_L
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_21_SpectrumLine') and o.name = 'FK_TBL_21_S_HAVE_37_2_TBL_37_E')
alter table tbl_21_SpectrumLine
   drop constraint FK_TBL_21_S_HAVE_37_2_TBL_37_E
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_22_Spektr') and o.name = 'FK_TBL_22_S_CONTAINS__TBL_21_S')
alter table tbl_22_Spektr
   drop constraint FK_TBL_22_S_CONTAINS__TBL_21_S
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_22_Spektr') and o.name = 'FK_TBL_22_S_HAS_10_22_TBL_10_C')
alter table tbl_22_Spektr
   drop constraint FK_TBL_22_S_HAS_10_22_TBL_10_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_22_Spektr') and o.name = 'FK_TBL_22_S_HAS_26_22_TBL_26_P')
alter table tbl_22_Spektr
   drop constraint FK_TBL_22_S_HAS_26_22_TBL_26_P
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_25_Isotop_ChemicalElement') and o.name = 'FK_TBL_25_I_HAS_10_25_TBL_10_C')
alter table tbl_25_Isotop_ChemicalElement
   drop constraint FK_TBL_25_I_HAS_10_25_TBL_10_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_26_Pigments') and o.name = 'FK_TBL_26_P_HAVE_27_2_TBL_27_G')
alter table tbl_26_Pigments
   drop constraint FK_TBL_26_P_HAVE_27_2_TBL_27_G
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_28_Works_of_Art_objects') and o.name = 'FK_TBL_28_W_INCLUDE_1_TBL_14_W')
alter table tbl_28_Works_of_Art_objects
   drop constraint FK_TBL_28_W_INCLUDE_1_TBL_14_W
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_28_Works_of_Art_objects') and o.name = 'FK_TBL_28_W_RELATIONS_TBL_1_US')
alter table tbl_28_Works_of_Art_objects
   drop constraint FK_TBL_28_W_RELATIONS_TBL_1_US
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_28_Works_of_Art_objects') and o.name = 'FK_TBL_28_W_ATTACH_31_TBL_31_R')
alter table tbl_28_Works_of_Art_objects
   drop constraint FK_TBL_28_W_ATTACH_31_TBL_31_R
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_28_Works_of_Art_objects') and o.name = 'FK_TBL_28_W_CHARACTER_TBL_36_R')
alter table tbl_28_Works_of_Art_objects
   drop constraint FK_TBL_28_W_CHARACTER_TBL_36_R
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_29_Icons_objects') and o.name = 'FK_TBL_29_I_INCLUDE_1_TBL_14_W')
alter table tbl_29_Icons_objects
   drop constraint FK_TBL_29_I_INCLUDE_1_TBL_14_W
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_29_Icons_objects') and o.name = 'FK_TBL_29_I_RELATIONS_TBL_1_US')
alter table tbl_29_Icons_objects
   drop constraint FK_TBL_29_I_RELATIONS_TBL_1_US
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_29_Icons_objects') and o.name = 'FK_TBL_29_I_ATTACH_31_TBL_31_R')
alter table tbl_29_Icons_objects
   drop constraint FK_TBL_29_I_ATTACH_31_TBL_31_R
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_29_Icons_objects') and o.name = 'FK_TBL_29_I_CHARACTER_TBL_36_R')
alter table tbl_29_Icons_objects
   drop constraint FK_TBL_29_I_CHARACTER_TBL_36_R
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_32_PlotFocus') and o.name = 'FK_TBL_32_P_CONDUCTS__TBL_1_US')
alter table tbl_32_PlotFocus
   drop constraint FK_TBL_32_P_CONDUCTS__TBL_1_US
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_32_PlotFocus') and o.name = 'FK_TBL_32_P_RELATIONS_TBL_29_I')
alter table tbl_32_PlotFocus
   drop constraint FK_TBL_32_P_RELATIONS_TBL_29_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_32_PlotFocus') and o.name = 'FK_TBL_32_P_RELATIONS_TBL_28_W')
alter table tbl_32_PlotFocus
   drop constraint FK_TBL_32_P_RELATIONS_TBL_28_W
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_32_PlotFocus') and o.name = 'FK_TBL_32_P_INCLUDE_3_TBL_45_F')
alter table tbl_32_PlotFocus
   drop constraint FK_TBL_32_P_INCLUDE_3_TBL_45_F
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_32_PlotFocus') and o.name = 'FK_TBL_32_P_ÑONTAINS__TBL_33_O')
alter table tbl_32_PlotFocus
   drop constraint FK_TBL_32_P_ÑONTAINS__TBL_33_O
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_33_ObjectsPhoto') and o.name = 'FK_TBL_33_O_HAS_35_33_TBL_29_I')
alter table tbl_33_ObjectsPhoto
   drop constraint FK_TBL_33_O_HAS_35_33_TBL_29_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_33_ObjectsPhoto') and o.name = 'FK_TBL_33_O_HAS_35_34_TBL_28_W')
alter table tbl_33_ObjectsPhoto
   drop constraint FK_TBL_33_O_HAS_35_34_TBL_28_W
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_37_ElementAtom') and o.name = 'FK_TBL_37_E_HOLD_39_3_TBL_39_C')
alter table tbl_37_ElementAtom
   drop constraint FK_TBL_37_E_HOLD_39_3_TBL_39_C
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_38_Isotope_ElementAtom') and o.name = 'FK_TBL_38_I_HAS_37_38_TBL_37_E')
alter table tbl_38_Isotope_ElementAtom
   drop constraint FK_TBL_38_I_HAS_37_38_TBL_37_E
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_41_Content') and o.name = 'FK_TBL_41_C_BELONG_37_TBL_37_E')
alter table tbl_41_Content
   drop constraint FK_TBL_41_C_BELONG_37_TBL_37_E
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_41_Content') and o.name = 'FK_TBL_41_C_BELONG_42_TBL_42_I')
alter table tbl_41_Content
   drop constraint FK_TBL_41_C_BELONG_42_TBL_42_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_41_Content') and o.name = 'FK_TBL_41_C_CONSIST_4_TBL_43_S')
alter table tbl_41_Content
   drop constraint FK_TBL_41_C_CONSIST_4_TBL_43_S
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_41_Content') and o.name = 'FK_TBL_41_C_INCLUDE_4_TBL_40_S')
alter table tbl_41_Content
   drop constraint FK_TBL_41_C_INCLUDE_4_TBL_40_S
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_42_Ions') and o.name = 'FK_TBL_42_I_INCL_37_4_TBL_37_E')
alter table tbl_42_Ions
   drop constraint FK_TBL_42_I_INCL_37_4_TBL_37_E
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_43_StatesOfMatter_Element_Atom') and o.name = 'FK_TBL_43_S_MOVE_37_4_TBL_37_E')
alter table tbl_43_StatesOfMatter_Element_Atom
   drop constraint FK_TBL_43_S_MOVE_37_4_TBL_37_E
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_45_FingerPrint') and o.name = 'FK_TBL_45_F_INCLUDE_3_TBL_32_P')
alter table tbl_45_FingerPrint
   drop constraint FK_TBL_45_F_INCLUDE_3_TBL_32_P
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_9_SpektrumLines_ChemicalElement') and o.name = 'FK_TBL_9_SP_HAS_32_92_TBL_32_P')
alter table tbl_9_SpektrumLines_ChemicalElement
   drop constraint FK_TBL_9_SP_HAS_32_92_TBL_32_P
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('tbl_9_SpektrumLines_ChemicalElement') and o.name = 'FK_TBL_9_SP_MATCHES_1_TBL_10_C')
alter table tbl_9_SpektrumLines_ChemicalElement
   drop constraint FK_TBL_9_SP_MATCHES_1_TBL_10_C
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Has_10_23')
            and   name  = 'Has_10_24_FK'
            and   indid > 0
            and   indid < 255)
   drop index Has_10_23.Has_10_24_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('Has_10_23')
            and   name  = 'Has_10_23_FK'
            and   indid > 0
            and   indid < 255)
   drop index Has_10_23.Has_10_23_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Has_10_23')
            and   type = 'U')
   drop table Has_10_23
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('include_22_32')
            and   name  = 'include_22_33_FK'
            and   indid > 0
            and   indid < 255)
   drop index include_22_32.include_22_33_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('include_22_32')
            and   name  = 'include_22_32_FK'
            and   indid > 0
            and   indid < 255)
   drop index include_22_32.include_22_32_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('include_22_32')
            and   type = 'U')
   drop table include_22_32
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_10_ChemicalElement')
            and   name  = 'Has_24_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_10_ChemicalElement.Has_24_10_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_10_ChemicalElement')
            and   type = 'U')
   drop table tbl_10_ChemicalElement
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_11_AuthorPictures')
            and   name  = 'Include_13_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_11_AuthorPictures.Include_13_11_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_11_AuthorPictures')
            and   name  = 'Contains_12_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_11_AuthorPictures.Contains_12_11_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_11_AuthorPictures')
            and   type = 'U')
   drop table tbl_11_AuthorPictures
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_12_GeografyPlace')
            and   name  = 'Located_15_12_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_12_GeografyPlace.Located_15_12_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_12_GeografyPlace')
            and   type = 'U')
   drop table tbl_12_GeografyPlace
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_13_HistoryPeriod')
            and   type = 'U')
   drop table tbl_13_HistoryPeriod
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_14_WorksOfArt')
            and   name  = 'Has_11_14_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_14_WorksOfArt.Has_11_14_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_14_WorksOfArt')
            and   type = 'U')
   drop table tbl_14_WorksOfArt
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_15_Country')
            and   type = 'U')
   drop table tbl_15_Country
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_17_PassportResearch')
            and   name  = 'Include_20_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_17_PassportResearch.Include_20_17_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_17_PassportResearch')
            and   name  = 'Has_14_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_17_PassportResearch.Has_14_17_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_17_PassportResearch')
            and   type = 'U')
   drop table tbl_17_PassportResearch
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_18_RemarkOfDate')
            and   name  = 'Have_19_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_18_RemarkOfDate.Have_19_18_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_18_RemarkOfDate')
            and   name  = 'Contain_14_18_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_18_RemarkOfDate.Contain_14_18_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_18_RemarkOfDate')
            and   type = 'U')
   drop table tbl_18_RemarkOfDate
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_19_DateOfCreated')
            and   type = 'U')
   drop table tbl_19_DateOfCreated
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_1_User')
            and   name  = 'Belongs_5_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_1_User.Belongs_5_4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_1_User')
            and   name  = 'Live_6_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_1_User.Live_6_4_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_1_User')
            and   name  = 'Has_2_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_1_User.Has_2_1_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_1_User')
            and   name  = 'Has_3_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_1_User.Has_3_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_1_User')
            and   type = 'U')
   drop table tbl_1_User
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_20_InstrumentalMethods')
            and   type = 'U')
   drop table tbl_20_InstrumentalMethods
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_21_SpectrumLine')
            and   name  = 'have_37_21_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_21_SpectrumLine.have_37_21_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_21_SpectrumLine')
            and   name  = 'Contains_34_21_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_21_SpectrumLine.Contains_34_21_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_21_SpectrumLine')
            and   type = 'U')
   drop table tbl_21_SpectrumLine
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_22_Spektr')
            and   name  = 'Has_26_22_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_22_Spektr.Has_26_22_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_22_Spektr')
            and   name  = 'Has_10_22_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_22_Spektr.Has_10_22_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_22_Spektr')
            and   name  = 'Contains_21_22_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_22_Spektr.Contains_21_22_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_22_Spektr')
            and   type = 'U')
   drop table tbl_22_Spektr
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_23_StatesOfMatter_ChemicalElement')
            and   type = 'U')
   drop table tbl_23_StatesOfMatter_ChemicalElement
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_24_CrystalStructures_ChemicalElement')
            and   type = 'U')
   drop table tbl_24_CrystalStructures_ChemicalElement
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_25_Isotop_ChemicalElement')
            and   name  = 'Has_10_25_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_25_Isotop_ChemicalElement.Has_10_25_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_25_Isotop_ChemicalElement')
            and   type = 'U')
   drop table tbl_25_Isotop_ChemicalElement
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_26_Pigments')
            and   name  = 'Have_27_26_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_26_Pigments.Have_27_26_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_26_Pigments')
            and   type = 'U')
   drop table tbl_26_Pigments
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_27_Group')
            and   type = 'U')
   drop table tbl_27_Group
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_28_Works_of_Art_objects')
            and   name  = 'Include_14_36_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_28_Works_of_Art_objects.Include_14_36_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_28_Works_of_Art_objects')
            and   name  = 'Relationship_1_36_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_28_Works_of_Art_objects.Relationship_1_36_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_28_Works_of_Art_objects')
            and   name  = 'characterize_36_36_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_28_Works_of_Art_objects.characterize_36_36_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_28_Works_of_Art_objects')
            and   name  = 'attach_31_36_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_28_Works_of_Art_objects.attach_31_36_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_28_Works_of_Art_objects')
            and   type = 'U')
   drop table tbl_28_Works_of_Art_objects
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_29_Icons_objects')
            and   name  = 'Include_14_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_29_Icons_objects.Include_14_35_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_29_Icons_objects')
            and   name  = 'Relationship_1_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_29_Icons_objects.Relationship_1_35_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_29_Icons_objects')
            and   name  = 'characterize_36_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_29_Icons_objects.characterize_36_35_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_29_Icons_objects')
            and   name  = 'attach_31_35_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_29_Icons_objects.attach_31_35_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_29_Icons_objects')
            and   type = 'U')
   drop table tbl_29_Icons_objects
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_2_Roles')
            and   type = 'U')
   drop table tbl_2_Roles
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_31_ResearchObjectsCategory')
            and   type = 'U')
   drop table tbl_31_ResearchObjectsCategory
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_32_PlotFocus')
            and   name  = 'Relationship_45_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_32_PlotFocus.Relationship_45_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_32_PlotFocus')
            and   name  = 'Relationship_46_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_32_PlotFocus.Relationship_46_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_32_PlotFocus')
            and   name  = 'Ñontains_33_32_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_32_PlotFocus.Ñontains_33_32_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_32_PlotFocus')
            and   name  = 'include_32_45_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_32_PlotFocus.include_32_45_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_32_PlotFocus')
            and   name  = 'Conducts_1_32_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_32_PlotFocus.Conducts_1_32_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_32_PlotFocus')
            and   type = 'U')
   drop table tbl_32_PlotFocus
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_33_ObjectsPhoto')
            and   name  = 'has_35_33_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_33_ObjectsPhoto.has_35_33_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_33_ObjectsPhoto')
            and   name  = 'has_35_34_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_33_ObjectsPhoto.has_35_34_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_33_ObjectsPhoto')
            and   type = 'U')
   drop table tbl_33_ObjectsPhoto
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_34_LibrarySpectrumLines')
            and   type = 'U')
   drop table tbl_34_LibrarySpectrumLines
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_36_ResearchObjectType')
            and   type = 'U')
   drop table tbl_36_ResearchObjectType
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_37_ElementAtom')
            and   name  = 'hold_39_37_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_37_ElementAtom.hold_39_37_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_37_ElementAtom')
            and   type = 'U')
   drop table tbl_37_ElementAtom
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_38_Isotope_ElementAtom')
            and   name  = 'has_37_38_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_38_Isotope_ElementAtom.has_37_38_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_38_Isotope_ElementAtom')
            and   type = 'U')
   drop table tbl_38_Isotope_ElementAtom
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_39_CrystalStructures_Element_Atom')
            and   type = 'U')
   drop table tbl_39_CrystalStructures_Element_Atom
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_3_Privileges')
            and   type = 'U')
   drop table tbl_3_Privileges
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_40_SpektrumMeasurement')
            and   type = 'U')
   drop table tbl_40_SpektrumMeasurement
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_41_Content')
            and   name  = 'belong_42_41_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_41_Content.belong_42_41_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_41_Content')
            and   name  = 'belong_37_41_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_41_Content.belong_37_41_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_41_Content')
            and   name  = 'consist_43_41_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_41_Content.consist_43_41_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_41_Content')
            and   name  = 'include_40_41_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_41_Content.include_40_41_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_41_Content')
            and   type = 'U')
   drop table tbl_41_Content
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_42_Ions')
            and   name  = 'incl_37_42_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_42_Ions.incl_37_42_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_42_Ions')
            and   type = 'U')
   drop table tbl_42_Ions
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_43_StatesOfMatter_Element_Atom')
            and   name  = 'move_37_43_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_43_StatesOfMatter_Element_Atom.move_37_43_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_43_StatesOfMatter_Element_Atom')
            and   type = 'U')
   drop table tbl_43_StatesOfMatter_Element_Atom
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_45_FingerPrint')
            and   name  = 'include_32_46_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_45_FingerPrint.include_32_46_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_45_FingerPrint')
            and   type = 'U')
   drop table tbl_45_FingerPrint
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_5_Organization')
            and   type = 'U')
   drop table tbl_5_Organization
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_6_City')
            and   type = 'U')
   drop table tbl_6_City
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_9_SpektrumLines_ChemicalElement')
            and   name  = 'Has_32_92_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_9_SpektrumLines_ChemicalElement.Has_32_92_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('tbl_9_SpektrumLines_ChemicalElement')
            and   name  = 'Matches_10_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index tbl_9_SpektrumLines_ChemicalElement.Matches_10_9_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tbl_9_SpektrumLines_ChemicalElement')
            and   type = 'U')
   drop table tbl_9_SpektrumLines_ChemicalElement
go

/*==============================================================*/
/* Table: Has_10_23                                             */
/*==============================================================*/
create table Has_10_23 (
   ChemicalElementId    int                  not null,
   StatesOfMatterId     int                  not null,
   constraint PK_HAS_10_23 primary key (ChemicalElementId, StatesOfMatterId)
)
go

/*==============================================================*/
/* Index: Has_10_23_FK                                          */
/*==============================================================*/
create index Has_10_23_FK on Has_10_23 (
ChemicalElementId ASC
)
go

/*==============================================================*/
/* Index: Has_10_24_FK                                          */
/*==============================================================*/
create index Has_10_24_FK on Has_10_23 (
StatesOfMatterId ASC
)
go

/*==============================================================*/
/* Table: include_22_32                                         */
/*==============================================================*/
create table include_22_32 (
   SpektrId             int                  not null,
   PlotFocusId          int                  not null,
   constraint PK_INCLUDE_22_32 primary key (SpektrId, PlotFocusId)
)
go

/*==============================================================*/
/* Index: include_22_32_FK                                      */
/*==============================================================*/
create index include_22_32_FK on include_22_32 (
SpektrId ASC
)
go

/*==============================================================*/
/* Index: include_22_33_FK                                      */
/*==============================================================*/
create index include_22_33_FK on include_22_32 (
PlotFocusId ASC
)
go

/*==============================================================*/
/* Table: tbl_10_ChemicalElement                                */
/*==============================================================*/
create table tbl_10_ChemicalElement (
   ChemicalElementId    int                  not null,
   CrystalStructureId   int                  not null,
   ChemicalElementDescription varchar(100)         null,
   ChemicalElementAtomicNumber int                  null,
   ChemicalElementAtomicWeight float                null,
   ChemicalElementNucleusCharge int                  null,
   ChemicalElementIonCharge int                  null,
   constraint PK_TBL_10_CHEMICALELEMENT primary key nonclustered (ChemicalElementId)
)
go

/*==============================================================*/
/* Index: Has_24_10_FK                                          */
/*==============================================================*/
create index Has_24_10_FK on tbl_10_ChemicalElement (
CrystalStructureId ASC
)
go

/*==============================================================*/
/* Table: tbl_11_AuthorPictures                                 */
/*==============================================================*/
create table tbl_11_AuthorPictures (
   AuthorPicturesId     int                  not null,
   GeografyPlaceId      int                  null,
   HistoryPeriodId      int                  not null,
   AuthorFirstName      varchar(50)          null,
   AuthorLastName       varchar(50)          null,
   AuthorMiddleName     varchar(50)          null,
   AuthorDate_of_birth  datetime             null,
   AuthorOtherDates     datetime             null,
   AuthorBiography      varchar(8000)        null,
   constraint PK_TBL_11_AUTHORPICTURES primary key nonclustered (AuthorPicturesId)
)
go

/*==============================================================*/
/* Index: Contains_12_11_FK                                     */
/*==============================================================*/
create index Contains_12_11_FK on tbl_11_AuthorPictures (
GeografyPlaceId ASC
)
go

/*==============================================================*/
/* Index: Include_13_11_FK                                      */
/*==============================================================*/
create index Include_13_11_FK on tbl_11_AuthorPictures (
HistoryPeriodId ASC
)
go

/*==============================================================*/
/* Table: tbl_12_GeografyPlace                                  */
/*==============================================================*/
create table tbl_12_GeografyPlace (
   GeografyPlaceId      int                  not null,
   CountryId            int                  not null,
   GeografyPlaceCity    varchar(100)         null,
   Administrative_District_1 varchar(200)         null,
   Administrative_District_2 varchar(200)         null,
   Administrative_District_3 varchar(200)         null,
   constraint PK_TBL_12_GEOGRAFYPLACE primary key nonclustered (GeografyPlaceId)
)
go

/*==============================================================*/
/* Index: Located_15_12_FK                                      */
/*==============================================================*/
create index Located_15_12_FK on tbl_12_GeografyPlace (
CountryId ASC
)
go

/*==============================================================*/
/* Table: tbl_13_HistoryPeriod                                  */
/*==============================================================*/
create table tbl_13_HistoryPeriod (
   HistoryPeriodId      int                  not null,
   HistoryPeriodName    varchar(100)         null,
   HistoryPeriodIdDescription text                 null,
   HistoryPeriodIdDates datetime             null,
   constraint PK_TBL_13_HISTORYPERIOD primary key nonclustered (HistoryPeriodId)
)
go

/*==============================================================*/
/* Table: tbl_14_WorksOfArt                                     */
/*==============================================================*/
create table tbl_14_WorksOfArt (
   PictureId            int                  not null,
   AuthorPicturesId     int                  null,
   PictureName          varchar(100)         null,
   Size                 varchar(10)          null,
   PicturePhoto         image                null,
   Material             varchar(40)          null,
   Technique            varchar(100)         null,
   DateResearch         datetime             null,
   PurposeOfResearch    varchar(200)         null,
   Conclusion           varchar(400)         null,
   StatusWorks          varchar(50)          null,
   constraint PK_TBL_14_WORKSOFART primary key nonclustered (PictureId)
)
go

/*==============================================================*/
/* Index: Has_11_14_FK                                          */
/*==============================================================*/
create index Has_11_14_FK on tbl_14_WorksOfArt (
AuthorPicturesId ASC
)
go

/*==============================================================*/
/* Table: tbl_15_Country                                        */
/*==============================================================*/
create table tbl_15_Country (
   CountryId            int                  not null,
   CountryName          varchar(100)         null,
   CountryDescription   varchar(500)         null,
   constraint PK_TBL_15_COUNTRY primary key nonclustered (CountryId)
)
go

/*==============================================================*/
/* Table: tbl_17_PassportResearch                               */
/*==============================================================*/
create table tbl_17_PassportResearch (
   PassportResearchId   int                  not null,
   PictureId            int                  not null,
   InstrumentalMethodsId int                  null,
   Conclusion_the_method varchar(255)         null,
   constraint PK_TBL_17_PASSPORTRESEARCH primary key nonclustered (PassportResearchId)
)
go

/*==============================================================*/
/* Index: Has_14_17_FK                                          */
/*==============================================================*/
create index Has_14_17_FK on tbl_17_PassportResearch (
PictureId ASC
)
go

/*==============================================================*/
/* Index: Include_20_17_FK                                      */
/*==============================================================*/
create index Include_20_17_FK on tbl_17_PassportResearch (
InstrumentalMethodsId ASC
)
go

/*==============================================================*/
/* Table: tbl_18_RemarkOfDate                                   */
/*==============================================================*/
create table tbl_18_RemarkOfDate (
   RemarkOfDateId       int                  not null,
   PictureId            int                  null,
   DateOfCreatedId      int                  null,
   RemarkOfDateCreate   varchar(300)         null,
   constraint PK_TBL_18_REMARKOFDATE primary key nonclustered (RemarkOfDateId)
)
go

/*==============================================================*/
/* Index: Contain_14_18_FK                                      */
/*==============================================================*/
create index Contain_14_18_FK on tbl_18_RemarkOfDate (
PictureId ASC
)
go

/*==============================================================*/
/* Index: Have_19_18_FK                                         */
/*==============================================================*/
create index Have_19_18_FK on tbl_18_RemarkOfDate (
DateOfCreatedId ASC
)
go

/*==============================================================*/
/* Table: tbl_19_DateOfCreated                                  */
/*==============================================================*/
create table tbl_19_DateOfCreated (
   DateOfCreatedId      int                  not null,
   DateOfCreated        datetime             null,
   constraint PK_TBL_19_DATEOFCREATED primary key nonclustered (DateOfCreatedId)
)
go

/*==============================================================*/
/* Table: tbl_1_User                                            */
/*==============================================================*/
create table tbl_1_User (
   UserId               int                  not null,
   OrganizationId       int                  not null,
   RoleId               int                  not null,
   PrivilegeId          int                  not null,
   CityId               int                  not null,
   UserFirstName        varchar(100)         null,
   UserLastName         varchar(100)         null,
   UserMiddleName       varchar(100)         null,
   UserEmail            varchar(50)          null,
   UserPhoneNumber      varchar(20)          null,
   UserMobilePhoneNumber varchar(20)          null,
   Login                varchar(50)          null,
   Password             varchar(50)          null,
   constraint PK_TBL_1_USER primary key nonclustered (UserId)
)
go

/*==============================================================*/
/* Index: Has_3_1_FK                                            */
/*==============================================================*/
create index Has_3_1_FK on tbl_1_User (
PrivilegeId ASC
)
go

/*==============================================================*/
/* Index: Has_2_1_FK                                            */
/*==============================================================*/
create index Has_2_1_FK on tbl_1_User (
RoleId ASC
)
go

/*==============================================================*/
/* Index: Live_6_4_FK                                           */
/*==============================================================*/
create index Live_6_4_FK on tbl_1_User (
CityId ASC
)
go

/*==============================================================*/
/* Index: Belongs_5_4_FK                                        */
/*==============================================================*/
create index Belongs_5_4_FK on tbl_1_User (
OrganizationId ASC
)
go

/*==============================================================*/
/* Table: tbl_20_InstrumentalMethods                            */
/*==============================================================*/
create table tbl_20_InstrumentalMethods (
   InstrumentalMethodsId int                  not null,
   InstrumentalMethodsName text                 null,
   InstrumentalMethodsDescription text                 null,
   constraint PK_TBL_20_INSTRUMENTALMETHODS primary key nonclustered (InstrumentalMethodsId)
)
go

/*==============================================================*/
/* Table: tbl_21_SpectrumLine                                   */
/*==============================================================*/
create table tbl_21_SpectrumLine (
   SpectrumLineId       int                  not null,
   ElementAtomId        int                  null,
   LibraryId            int                  not null,
   SpectrumLineDate     datetime             null,
   SpectrumLinePersonName varchar(50)          null,
   SpectrumLineWavelLength float                null,
   OtherOptions         varchar(300)         null,
   constraint PK_TBL_21_SPECTRUMLINE primary key nonclustered (SpectrumLineId)
)
go

/*==============================================================*/
/* Index: Contains_34_21_FK                                     */
/*==============================================================*/
create index Contains_34_21_FK on tbl_21_SpectrumLine (
LibraryId ASC
)
go

/*==============================================================*/
/* Index: have_37_21_FK                                         */
/*==============================================================*/
create index have_37_21_FK on tbl_21_SpectrumLine (
ElementAtomId ASC
)
go

/*==============================================================*/
/* Table: tbl_22_Spektr                                         */
/*==============================================================*/
create table tbl_22_Spektr (
   SpektrId             int                  not null,
   SpectrumLineId       int                  not null,
   PigmentsId           int                  null,
   ChemicalElementId    int                  not null,
   SpektrWaveLenght     float                null,
   LineDescription      varchar(100)         null,
   SpektrsBase          varchar(100)         null,
   SpektrIntensity      float                null,
   PeakArea             float                null,
   constraint PK_TBL_22_SPEKTR primary key nonclustered (SpektrId)
)
go

/*==============================================================*/
/* Index: Contains_21_22_FK                                     */
/*==============================================================*/
create index Contains_21_22_FK on tbl_22_Spektr (
SpectrumLineId ASC
)
go

/*==============================================================*/
/* Index: Has_10_22_FK                                          */
/*==============================================================*/
create index Has_10_22_FK on tbl_22_Spektr (
ChemicalElementId ASC
)
go

/*==============================================================*/
/* Index: Has_26_22_FK                                          */
/*==============================================================*/
create index Has_26_22_FK on tbl_22_Spektr (
PigmentsId ASC
)
go

/*==============================================================*/
/* Table: tbl_23_StatesOfMatter_ChemicalElement                 */
/*==============================================================*/
create table tbl_23_StatesOfMatter_ChemicalElement (
   StatesOfMatterId     int                  not null,
   StatesOfMatterIdDescription varchar(500)         null,
   constraint PK_TBL_23_STATESOFMATTER_CHEMI primary key nonclustered (StatesOfMatterId)
)
go

/*==============================================================*/
/* Table: tbl_24_CrystalStructures_ChemicalElement              */
/*==============================================================*/
create table tbl_24_CrystalStructures_ChemicalElement (
   CrystalStructureId   int                  not null,
   CrystalStructureDescription varchar(500)         null,
   constraint PK_TBL_24_CRYSTALSTRUCTURES_CH primary key nonclustered (CrystalStructureId)
)
go

/*==============================================================*/
/* Table: tbl_25_Isotop_ChemicalElement                         */
/*==============================================================*/
create table tbl_25_Isotop_ChemicalElement (
   IsotopId             int                  not null,
   ChemicalElementId    int                  not null,
   IsotopMassValue      int                  null,
   constraint PK_TBL_25_ISOTOP_CHEMICALELEME primary key nonclustered (IsotopId)
)
go

/*==============================================================*/
/* Index: Has_10_25_FK                                          */
/*==============================================================*/
create index Has_10_25_FK on tbl_25_Isotop_ChemicalElement (
ChemicalElementId ASC
)
go

/*==============================================================*/
/* Table: tbl_26_Pigments                                       */
/*==============================================================*/
create table tbl_26_Pigments (
   PigmentsId           int                  not null,
   GroupId              int                  null,
   PigmentColor         varchar(40)          null,
   PigmentChemicalFormula varchar(100)         null,
   PigmentYearUsed      datetime             null,
   PigmentWhereUsed     varchar(100)         null,
   PigmentLiterature    varchar(256)         null,
   constraint PK_TBL_26_PIGMENTS primary key nonclustered (PigmentsId)
)
go

/*==============================================================*/
/* Index: Have_27_26_FK                                         */
/*==============================================================*/
create index Have_27_26_FK on tbl_26_Pigments (
GroupId ASC
)
go

/*==============================================================*/
/* Table: tbl_27_Group                                          */
/*==============================================================*/
create table tbl_27_Group (
   GroupId              int                  not null,
   GroupName            varchar(100)         null,
   constraint PK_TBL_27_GROUP primary key nonclustered (GroupId)
)
go

/*==============================================================*/
/* Table: tbl_28_Works_of_Art_objects                           */
/*==============================================================*/
create table tbl_28_Works_of_Art_objects (
   ResearchObjectId     int                  not null,
   PictureId            int                  null,
   ResearchObjectsCategoryId int                  null,
   UserId               int                  not null,
   ResearchObjectTypeId int                  not null,
   ResearchObjectName   varchar(100)         null,
   InertyPow            int                  null,
   DateFromOb           datetime             null,
   constraint PK_TBL_28_WORKS_OF_ART_OBJECTS primary key (ResearchObjectId)
)
go

/*==============================================================*/
/* Index: attach_31_36_FK                                       */
/*==============================================================*/
create index attach_31_36_FK on tbl_28_Works_of_Art_objects (
ResearchObjectsCategoryId ASC
)
go

/*==============================================================*/
/* Index: characterize_36_36_FK                                 */
/*==============================================================*/
create index characterize_36_36_FK on tbl_28_Works_of_Art_objects (
ResearchObjectTypeId ASC
)
go

/*==============================================================*/
/* Index: Relationship_1_36_FK                                  */
/*==============================================================*/
create index Relationship_1_36_FK on tbl_28_Works_of_Art_objects (
UserId ASC
)
go

/*==============================================================*/
/* Index: Include_14_36_FK                                      */
/*==============================================================*/
create index Include_14_36_FK on tbl_28_Works_of_Art_objects (
PictureId ASC
)
go

/*==============================================================*/
/* Table: tbl_29_Icons_objects                                  */
/*==============================================================*/
create table tbl_29_Icons_objects (
   ResearchObjectId     int                  not null,
   PictureId            int                  null,
   ResearchObjectsCategoryId int                  null,
   UserId               int                  not null,
   ResearchObjectTypeId int                  not null,
   ResearchObjectName   varchar(100)         null,
   InertyPow            int                  null,
   DateFromOb           datetime             null,
   constraint PK_TBL_29_ICONS_OBJECTS primary key (ResearchObjectId)
)
go

/*==============================================================*/
/* Index: attach_31_35_FK                                       */
/*==============================================================*/
create index attach_31_35_FK on tbl_29_Icons_objects (
ResearchObjectsCategoryId ASC
)
go

/*==============================================================*/
/* Index: characterize_36_35_FK                                 */
/*==============================================================*/
create index characterize_36_35_FK on tbl_29_Icons_objects (
ResearchObjectTypeId ASC
)
go

/*==============================================================*/
/* Index: Relationship_1_35_FK                                  */
/*==============================================================*/
create index Relationship_1_35_FK on tbl_29_Icons_objects (
UserId ASC
)
go

/*==============================================================*/
/* Index: Include_14_35_FK                                      */
/*==============================================================*/
create index Include_14_35_FK on tbl_29_Icons_objects (
PictureId ASC
)
go

/*==============================================================*/
/* Table: tbl_2_Roles                                           */
/*==============================================================*/
create table tbl_2_Roles (
   RoleId               int                  not null,
   RoleName             varchar(50)          null,
   constraint PK_TBL_2_ROLES primary key nonclustered (RoleId)
)
go

/*==============================================================*/
/* Table: tbl_31_ResearchObjectsCategory                        */
/*==============================================================*/
create table tbl_31_ResearchObjectsCategory (
   ResearchObjectsCategoryId int                  not null,
   ResearchObjectsCategoryName varchar(200)         null,
   ResearchObjectsCategoryValue varchar(500)         null,
   constraint PK_TBL_31_RESEARCHOBJECTSCATEG primary key nonclustered (ResearchObjectsCategoryId)
)
go

/*==============================================================*/
/* Table: tbl_32_PlotFocus                                      */
/*==============================================================*/
create table tbl_32_PlotFocus (
   PlotFocusId          int                  not null,
   ObjectsPhotoId       int                  null,
   UserId               int                  not null,
   FingerPrintId        int                  null,
   ResearchObjectId     int                  not null,
   tbl_ResearchObjectId int                  not null,
   PlotFocusDate        datetime             null,
   PlotFocusTime        datetime             null,
   LabelFocus           int                  null,
   constraint PK_TBL_32_PLOTFOCUS primary key nonclustered (PlotFocusId)
)
go

/*==============================================================*/
/* Index: Conducts_1_32_FK                                      */
/*==============================================================*/
create index Conducts_1_32_FK on tbl_32_PlotFocus (
UserId ASC
)
go

/*==============================================================*/
/* Index: include_32_45_FK                                      */
/*==============================================================*/
create index include_32_45_FK on tbl_32_PlotFocus (
FingerPrintId ASC
)
go

/*==============================================================*/
/* Index: Ñontains_33_32_FK                                     */
/*==============================================================*/
create index Ñontains_33_32_FK on tbl_32_PlotFocus (
ObjectsPhotoId ASC
)
go

/*==============================================================*/
/* Index: Relationship_46_FK                                    */
/*==============================================================*/
create index Relationship_46_FK on tbl_32_PlotFocus (
ResearchObjectId ASC
)
go

/*==============================================================*/
/* Index: Relationship_45_FK                                    */
/*==============================================================*/
create index Relationship_45_FK on tbl_32_PlotFocus (
tbl_ResearchObjectId ASC
)
go

/*==============================================================*/
/* Table: tbl_33_ObjectsPhoto                                   */
/*==============================================================*/
create table tbl_33_ObjectsPhoto (
   ObjectsPhotoId       int                  not null,
   ResearchObjectId     int                  null,
   tbl_ResearchObjectId int                  null,
   ObjectsPhotoFile     image                null,
   ObjectsPhotoDate     datetime             null,
   constraint PK_TBL_33_OBJECTSPHOTO primary key nonclustered (ObjectsPhotoId)
)
go

/*==============================================================*/
/* Index: has_35_34_FK                                          */
/*==============================================================*/
create index has_35_34_FK on tbl_33_ObjectsPhoto (
ResearchObjectId ASC
)
go

/*==============================================================*/
/* Index: has_35_33_FK                                          */
/*==============================================================*/
create index has_35_33_FK on tbl_33_ObjectsPhoto (
tbl_ResearchObjectId ASC
)
go

/*==============================================================*/
/* Table: tbl_34_LibrarySpectrumLines                           */
/*==============================================================*/
create table tbl_34_LibrarySpectrumLines (
   LibraryId            int                  not null,
   LibraryName          varchar(50)          null,
   LibraryCooment       varchar(500)         null,
   constraint PK_TBL_34_LIBRARYSPECTRUMLINES primary key nonclustered (LibraryId)
)
go

/*==============================================================*/
/* Table: tbl_36_ResearchObjectType                             */
/*==============================================================*/
create table tbl_36_ResearchObjectType (
   ResearchObjectTypeId int                  not null,
   ResearchObjectTypeName varchar(100)         null,
   constraint PK_TBL_36_RESEARCHOBJECTTYPE primary key nonclustered (ResearchObjectTypeId)
)
go

/*==============================================================*/
/* Table: tbl_37_ElementAtom                                    */
/*==============================================================*/
create table tbl_37_ElementAtom (
   ElementAtomId        int                  not null,
   CrystalStructuresId  int                  not null,
   ElementAtomDescription varchar(200)         null,
   AtomicNumber         int                  null,
   AtomicWeight         float                null,
   SymbolAtom           varchar(4)           null,
   AtomRussianName      varchar(20)          null,
   AtomEnglishName      varchar(20)          null,
   AtomYearOfDiscovery  datetime             null,
   AtomDescriptionDiscoveries varchar(200)         null,
   constraint PK_TBL_37_ELEMENTATOM primary key nonclustered (ElementAtomId)
)
go

/*==============================================================*/
/* Index: hold_39_37_FK                                         */
/*==============================================================*/
create index hold_39_37_FK on tbl_37_ElementAtom (
CrystalStructuresId ASC
)
go

/*==============================================================*/
/* Table: tbl_38_Isotope_ElementAtom                            */
/*==============================================================*/
create table tbl_38_Isotope_ElementAtom (
   IsotopeId            int                  not null,
   ElementAtomId        int                  not null,
   IsotopeMassValue     float                null,
   IsotopeDescription   varchar(300)         null,
   IsotopeRussionName   varchar(20)          null,
   IsotopeEnglishName   varchar(20)          null,
   IsotopeYearOfDiscovery datetime             null,
   IsotopeDescriptionDiscovery varchar(300)         null,
   constraint PK_TBL_38_ISOTOPE_ELEMENTATOM primary key nonclustered (IsotopeId)
)
go

/*==============================================================*/
/* Index: has_37_38_FK                                          */
/*==============================================================*/
create index has_37_38_FK on tbl_38_Isotope_ElementAtom (
ElementAtomId ASC
)
go

/*==============================================================*/
/* Table: tbl_39_CrystalStructures_Element_Atom                 */
/*==============================================================*/
create table tbl_39_CrystalStructures_Element_Atom (
   CrystalStructuresId  int                  not null,
   CrystalStructuresName varchar(100)         null,
   CrystalStructuresDescription varchar(500)         null,
   CrystalStructuresSymbol char(4)              null,
   constraint PK_TBL_39_CRYSTALSTRUCTURES_EL primary key nonclustered (CrystalStructuresId)
)
go

/*==============================================================*/
/* Table: tbl_3_Privileges                                      */
/*==============================================================*/
create table tbl_3_Privileges (
   PrivilegeId          int                  not null,
   Privilege            int                  null,
   PrivilegeDescription varchar(256)         null,
   constraint PK_TBL_3_PRIVILEGES primary key nonclustered (PrivilegeId)
)
go

/*==============================================================*/
/* Table: tbl_40_SpektrumMeasurement                            */
/*==============================================================*/
create table tbl_40_SpektrumMeasurement (
   SpektrumMeasurementId int                  not null,
   SpektrumMeasurementName varchar(50)          null,
   SpektrumMeasurementIdDescription varchar(500)         null,
   DateOfMeasurement    datetime             null,
   SpektrumMeasurementPlace varchar(100)         null,
   constraint PK_TBL_40_SPEKTRUMMEASUREMENT primary key nonclustered (SpektrumMeasurementId)
)
go

/*==============================================================*/
/* Table: tbl_41_Content                                        */
/*==============================================================*/
create table tbl_41_Content (
   ContentId            int                  not null,
   StatesOfMatterEAId   int                  not null,
   SpektrumMeasurementId int                  not null,
   IonId                int                  null,
   ElementAtomId        int                  not null,
   ContentWaveLenght    float                null,
   ContentName          varchar(100)         null,
   constraint PK_TBL_41_CONTENT primary key nonclustered (ContentId)
)
go

/*==============================================================*/
/* Index: include_40_41_FK                                      */
/*==============================================================*/
create index include_40_41_FK on tbl_41_Content (
SpektrumMeasurementId ASC
)
go

/*==============================================================*/
/* Index: consist_43_41_FK                                      */
/*==============================================================*/
create index consist_43_41_FK on tbl_41_Content (
StatesOfMatterEAId ASC
)
go

/*==============================================================*/
/* Index: belong_37_41_FK                                       */
/*==============================================================*/
create index belong_37_41_FK on tbl_41_Content (
ElementAtomId ASC
)
go

/*==============================================================*/
/* Index: belong_42_41_FK                                       */
/*==============================================================*/
create index belong_42_41_FK on tbl_41_Content (
IonId ASC
)
go

/*==============================================================*/
/* Table: tbl_42_Ions                                           */
/*==============================================================*/
create table tbl_42_Ions (
   IonId                int                  not null,
   ElementAtomId        int                  not null,
   IonDescription       varchar(400)         null,
   IonRussianName       varchar(20)          null,
   IonEnglishName       varchar(20)          null,
   IonCharge            varchar(5)           null,
   constraint PK_TBL_42_IONS primary key nonclustered (IonId)
)
go

/*==============================================================*/
/* Index: incl_37_42_FK                                         */
/*==============================================================*/
create index incl_37_42_FK on tbl_42_Ions (
ElementAtomId ASC
)
go

/*==============================================================*/
/* Table: tbl_43_StatesOfMatter_Element_Atom                    */
/*==============================================================*/
create table tbl_43_StatesOfMatter_Element_Atom (
   StatesOfMatterEAId   int                  not null,
   ElementAtomId        int                  null,
   StateName            varchar(100)         null,
   StateSymbol          varchar(5)           null,
   StateRussianName     varchar(20)          null,
   StateEnglishName     varchar(20)          null,
   StateYearOfDiscoveries datetime             null,
   StateDescruprionDiscoveries varchar(400)         null,
   constraint PK_TBL_43_STATESOFMATTER_ELEME primary key nonclustered (StatesOfMatterEAId)
)
go

/*==============================================================*/
/* Index: move_37_43_FK                                         */
/*==============================================================*/
create index move_37_43_FK on tbl_43_StatesOfMatter_Element_Atom (
ElementAtomId ASC
)
go

/*==============================================================*/
/* Table: tbl_45_FingerPrint                                    */
/*==============================================================*/
create table tbl_45_FingerPrint (
   FingerPrintId        int                  not null,
   PlotFocusId          int                  null,
   WavelenghtFinger     int                  null,
   IntensityFinger      int                  null,
   constraint PK_TBL_45_FINGERPRINT primary key nonclustered (FingerPrintId)
)
go

/*==============================================================*/
/* Index: include_32_46_FK                                      */
/*==============================================================*/
create index include_32_46_FK on tbl_45_FingerPrint (
PlotFocusId ASC
)
go

/*==============================================================*/
/* Table: tbl_5_Organization                                    */
/*==============================================================*/
create table tbl_5_Organization (
   OrganizationId       int                  not null,
   OrganizationStatus   varchar(100)         null,
   OrganizationType     varchar(100)         null,
   OrganizationDescription varchar(256)         null,
   OrganizationAdress   varchar(100)         null,
   OrganizationEmail    varchar(50)          null,
   OrganizationPhoneNumbe varchar(20)          null,
   constraint PK_TBL_5_ORGANIZATION primary key nonclustered (OrganizationId)
)
go

/*==============================================================*/
/* Table: tbl_6_City                                            */
/*==============================================================*/
create table tbl_6_City (
   CityId               int                  not null,
   UserCity             varchar(100)         null,
   Country              varchar(100)         null,
   AdministrativeDevision varchar(100)         null,
   Region               varchar(100)         null,
   constraint PK_TBL_6_CITY primary key nonclustered (CityId)
)
go

/*==============================================================*/
/* Table: tbl_9_SpektrumLines_ChemicalElement                   */
/*==============================================================*/
create table tbl_9_SpektrumLines_ChemicalElement (
   SpektrumLineChEId    int                  not null,
   PlotFocusId          int                  not null,
   ChemicalElementId    int                  null,
   SpektrumLineChEWavelength float                null,
   SpektrumLineChEIntensity float                null,
   constraint PK_TBL_9_SPEKTRUMLINES_CHEMICA primary key nonclustered (SpektrumLineChEId)
)
go

/*==============================================================*/
/* Index: Matches_10_9_FK                                       */
/*==============================================================*/
create index Matches_10_9_FK on tbl_9_SpektrumLines_ChemicalElement (
ChemicalElementId ASC
)
go

/*==============================================================*/
/* Index: Has_32_92_FK                                          */
/*==============================================================*/
create index Has_32_92_FK on tbl_9_SpektrumLines_ChemicalElement (
PlotFocusId ASC
)
go

alter table Has_10_23
   add constraint FK_HAS_10_2_HAS_10_23_TBL_10_C foreign key (ChemicalElementId)
      references tbl_10_ChemicalElement (ChemicalElementId)
go

alter table Has_10_23
   add constraint FK_HAS_10_2_HAS_10_24_TBL_23_S foreign key (StatesOfMatterId)
      references tbl_23_StatesOfMatter_ChemicalElement (StatesOfMatterId)
go

alter table include_22_32
   add constraint FK_INCLUDE__INCLUDE_2_TBL_22_S foreign key (SpektrId)
      references tbl_22_Spektr (SpektrId)
go

alter table include_22_32
   add constraint FK_INCLUDE__INCLUDE_2_TBL_32_P foreign key (PlotFocusId)
      references tbl_32_PlotFocus (PlotFocusId)
go

alter table tbl_10_ChemicalElement
   add constraint FK_TBL_10_C_HAS_24_10_TBL_24_C foreign key (CrystalStructureId)
      references tbl_24_CrystalStructures_ChemicalElement (CrystalStructureId)
go

alter table tbl_11_AuthorPictures
   add constraint FK_TBL_11_A_CONTAINS__TBL_12_G foreign key (GeografyPlaceId)
      references tbl_12_GeografyPlace (GeografyPlaceId)
go

alter table tbl_11_AuthorPictures
   add constraint FK_TBL_11_A_INCLUDE_1_TBL_13_H foreign key (HistoryPeriodId)
      references tbl_13_HistoryPeriod (HistoryPeriodId)
go

alter table tbl_12_GeografyPlace
   add constraint FK_TBL_12_G_LOCATED_1_TBL_15_C foreign key (CountryId)
      references tbl_15_Country (CountryId)
go

alter table tbl_14_WorksOfArt
   add constraint FK_TBL_14_W_HAS_11_14_TBL_11_A foreign key (AuthorPicturesId)
      references tbl_11_AuthorPictures (AuthorPicturesId)
go

alter table tbl_17_PassportResearch
   add constraint FK_TBL_17_P_HAS_14_17_TBL_14_W foreign key (PictureId)
      references tbl_14_WorksOfArt (PictureId)
go

alter table tbl_17_PassportResearch
   add constraint FK_TBL_17_P_INCLUDE_2_TBL_20_I foreign key (InstrumentalMethodsId)
      references tbl_20_InstrumentalMethods (InstrumentalMethodsId)
go

alter table tbl_18_RemarkOfDate
   add constraint FK_TBL_18_R_CONTAIN_1_TBL_14_W foreign key (PictureId)
      references tbl_14_WorksOfArt (PictureId)
go

alter table tbl_18_RemarkOfDate
   add constraint FK_TBL_18_R_HAVE_19_1_TBL_19_D foreign key (DateOfCreatedId)
      references tbl_19_DateOfCreated (DateOfCreatedId)
go

alter table tbl_1_User
   add constraint FK_TBL_1_US_BELONGS_5_TBL_5_OR foreign key (OrganizationId)
      references tbl_5_Organization (OrganizationId)
go

alter table tbl_1_User
   add constraint FK_TBL_1_US_HAS_2_1_TBL_2_RO foreign key (RoleId)
      references tbl_2_Roles (RoleId)
go

alter table tbl_1_User
   add constraint FK_TBL_1_US_HAS_3_1_TBL_3_PR foreign key (PrivilegeId)
      references tbl_3_Privileges (PrivilegeId)
go

alter table tbl_1_User
   add constraint FK_TBL_1_US_LIVE_6_4_TBL_6_CI foreign key (CityId)
      references tbl_6_City (CityId)
go

alter table tbl_21_SpectrumLine
   add constraint FK_TBL_21_S_CONTAINS__TBL_34_L foreign key (LibraryId)
      references tbl_34_LibrarySpectrumLines (LibraryId)
go

alter table tbl_21_SpectrumLine
   add constraint FK_TBL_21_S_HAVE_37_2_TBL_37_E foreign key (ElementAtomId)
      references tbl_37_ElementAtom (ElementAtomId)
go

alter table tbl_22_Spektr
   add constraint FK_TBL_22_S_CONTAINS__TBL_21_S foreign key (SpectrumLineId)
      references tbl_21_SpectrumLine (SpectrumLineId)
go

alter table tbl_22_Spektr
   add constraint FK_TBL_22_S_HAS_10_22_TBL_10_C foreign key (ChemicalElementId)
      references tbl_10_ChemicalElement (ChemicalElementId)
go

alter table tbl_22_Spektr
   add constraint FK_TBL_22_S_HAS_26_22_TBL_26_P foreign key (PigmentsId)
      references tbl_26_Pigments (PigmentsId)
go

alter table tbl_25_Isotop_ChemicalElement
   add constraint FK_TBL_25_I_HAS_10_25_TBL_10_C foreign key (ChemicalElementId)
      references tbl_10_ChemicalElement (ChemicalElementId)
go

alter table tbl_26_Pigments
   add constraint FK_TBL_26_P_HAVE_27_2_TBL_27_G foreign key (GroupId)
      references tbl_27_Group (GroupId)
go

alter table tbl_28_Works_of_Art_objects
   add constraint FK_TBL_28_W_INCLUDE_1_TBL_14_W foreign key (PictureId)
      references tbl_14_WorksOfArt (PictureId)
go

alter table tbl_28_Works_of_Art_objects
   add constraint FK_TBL_28_W_RELATIONS_TBL_1_US foreign key (UserId)
      references tbl_1_User (UserId)
go

alter table tbl_28_Works_of_Art_objects
   add constraint FK_TBL_28_W_ATTACH_31_TBL_31_R foreign key (ResearchObjectsCategoryId)
      references tbl_31_ResearchObjectsCategory (ResearchObjectsCategoryId)
go

alter table tbl_28_Works_of_Art_objects
   add constraint FK_TBL_28_W_CHARACTER_TBL_36_R foreign key (ResearchObjectTypeId)
      references tbl_36_ResearchObjectType (ResearchObjectTypeId)
go

alter table tbl_29_Icons_objects
   add constraint FK_TBL_29_I_INCLUDE_1_TBL_14_W foreign key (PictureId)
      references tbl_14_WorksOfArt (PictureId)
go

alter table tbl_29_Icons_objects
   add constraint FK_TBL_29_I_RELATIONS_TBL_1_US foreign key (UserId)
      references tbl_1_User (UserId)
go

alter table tbl_29_Icons_objects
   add constraint FK_TBL_29_I_ATTACH_31_TBL_31_R foreign key (ResearchObjectsCategoryId)
      references tbl_31_ResearchObjectsCategory (ResearchObjectsCategoryId)
go

alter table tbl_29_Icons_objects
   add constraint FK_TBL_29_I_CHARACTER_TBL_36_R foreign key (ResearchObjectTypeId)
      references tbl_36_ResearchObjectType (ResearchObjectTypeId)
go

alter table tbl_32_PlotFocus
   add constraint FK_TBL_32_P_CONDUCTS__TBL_1_US foreign key (UserId)
      references tbl_1_User (UserId)
go

alter table tbl_32_PlotFocus
   add constraint FK_TBL_32_P_RELATIONS_TBL_29_I foreign key (tbl_ResearchObjectId)
      references tbl_29_Icons_objects (ResearchObjectId)
go

alter table tbl_32_PlotFocus
   add constraint FK_TBL_32_P_RELATIONS_TBL_28_W foreign key (ResearchObjectId)
      references tbl_28_Works_of_Art_objects (ResearchObjectId)
go

alter table tbl_32_PlotFocus
   add constraint FK_TBL_32_P_INCLUDE_3_TBL_45_F foreign key (FingerPrintId)
      references tbl_45_FingerPrint (FingerPrintId)
go

alter table tbl_32_PlotFocus
   add constraint FK_TBL_32_P_ÑONTAINS__TBL_33_O foreign key (ObjectsPhotoId)
      references tbl_33_ObjectsPhoto (ObjectsPhotoId)
go

alter table tbl_33_ObjectsPhoto
   add constraint FK_TBL_33_O_HAS_35_33_TBL_29_I foreign key (tbl_ResearchObjectId)
      references tbl_29_Icons_objects (ResearchObjectId)
go

alter table tbl_33_ObjectsPhoto
   add constraint FK_TBL_33_O_HAS_35_34_TBL_28_W foreign key (ResearchObjectId)
      references tbl_28_Works_of_Art_objects (ResearchObjectId)
go

alter table tbl_37_ElementAtom
   add constraint FK_TBL_37_E_HOLD_39_3_TBL_39_C foreign key (CrystalStructuresId)
      references tbl_39_CrystalStructures_Element_Atom (CrystalStructuresId)
go

alter table tbl_38_Isotope_ElementAtom
   add constraint FK_TBL_38_I_HAS_37_38_TBL_37_E foreign key (ElementAtomId)
      references tbl_37_ElementAtom (ElementAtomId)
go

alter table tbl_41_Content
   add constraint FK_TBL_41_C_BELONG_37_TBL_37_E foreign key (ElementAtomId)
      references tbl_37_ElementAtom (ElementAtomId)
go

alter table tbl_41_Content
   add constraint FK_TBL_41_C_BELONG_42_TBL_42_I foreign key (IonId)
      references tbl_42_Ions (IonId)
go

alter table tbl_41_Content
   add constraint FK_TBL_41_C_CONSIST_4_TBL_43_S foreign key (StatesOfMatterEAId)
      references tbl_43_StatesOfMatter_Element_Atom (StatesOfMatterEAId)
go

alter table tbl_41_Content
   add constraint FK_TBL_41_C_INCLUDE_4_TBL_40_S foreign key (SpektrumMeasurementId)
      references tbl_40_SpektrumMeasurement (SpektrumMeasurementId)
go

alter table tbl_42_Ions
   add constraint FK_TBL_42_I_INCL_37_4_TBL_37_E foreign key (ElementAtomId)
      references tbl_37_ElementAtom (ElementAtomId)
go

alter table tbl_43_StatesOfMatter_Element_Atom
   add constraint FK_TBL_43_S_MOVE_37_4_TBL_37_E foreign key (ElementAtomId)
      references tbl_37_ElementAtom (ElementAtomId)
go

alter table tbl_45_FingerPrint
   add constraint FK_TBL_45_F_INCLUDE_3_TBL_32_P foreign key (PlotFocusId)
      references tbl_32_PlotFocus (PlotFocusId)
go

alter table tbl_9_SpektrumLines_ChemicalElement
   add constraint FK_TBL_9_SP_HAS_32_92_TBL_32_P foreign key (PlotFocusId)
      references tbl_32_PlotFocus (PlotFocusId)
go

alter table tbl_9_SpektrumLines_ChemicalElement
   add constraint FK_TBL_9_SP_MATCHES_1_TBL_10_C foreign key (ChemicalElementId)
      references tbl_10_ChemicalElement (ChemicalElementId)
go

