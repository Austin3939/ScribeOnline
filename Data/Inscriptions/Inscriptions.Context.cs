﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inscript_v5.Data.Inscriptions
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Inscriptv4Entities : DbContext
    {
        public Inscriptv4Entities()
            : base("name=Inscriptv4Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<InscriptionsGet_Result> InscriptionGetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InscriptionsGet_Result>("InscriptionGetList");
        }
    
        public virtual ObjectResult<InscriptionsGet_Result> InscriptionsGet(Nullable<int> inscriptionID)
        {
            var inscriptionIDParameter = inscriptionID.HasValue ?
                new ObjectParameter("InscriptionID", inscriptionID) :
                new ObjectParameter("InscriptionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InscriptionsGet_Result>("InscriptionsGet", inscriptionIDParameter);
        }
    
        public virtual int DeleteInscription(Nullable<int> inscriptionID)
        {
            var inscriptionIDParameter = inscriptionID.HasValue ?
                new ObjectParameter("InscriptionID", inscriptionID) :
                new ObjectParameter("InscriptionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteInscription", inscriptionIDParameter);
        }
    
        public virtual int InsertInscription(string inscriptionName, string date, string location, string language, ObjectParameter inscriptionID)
        {
            var inscriptionNameParameter = inscriptionName != null ?
                new ObjectParameter("InscriptionName", inscriptionName) :
                new ObjectParameter("InscriptionName", typeof(string));
    
            var dateParameter = date != null ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(string));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            var languageParameter = language != null ?
                new ObjectParameter("Language", language) :
                new ObjectParameter("Language", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertInscription", inscriptionNameParameter, dateParameter, locationParameter, languageParameter, inscriptionID);
        }
    
        public virtual int UpdateInscriptions(Nullable<int> inscriptionID, string inscriptionName, string date, Nullable<int> dateID, string location, Nullable<int> locationID, string language, Nullable<int> languageID)
        {
            var inscriptionIDParameter = inscriptionID.HasValue ?
                new ObjectParameter("InscriptionID", inscriptionID) :
                new ObjectParameter("InscriptionID", typeof(int));
    
            var inscriptionNameParameter = inscriptionName != null ?
                new ObjectParameter("InscriptionName", inscriptionName) :
                new ObjectParameter("InscriptionName", typeof(string));
    
            var dateParameter = date != null ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(string));
    
            var dateIDParameter = dateID.HasValue ?
                new ObjectParameter("DateID", dateID) :
                new ObjectParameter("DateID", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            var locationIDParameter = locationID.HasValue ?
                new ObjectParameter("LocationID", locationID) :
                new ObjectParameter("LocationID", typeof(int));
    
            var languageParameter = language != null ?
                new ObjectParameter("Language", language) :
                new ObjectParameter("Language", typeof(string));
    
            var languageIDParameter = languageID.HasValue ?
                new ObjectParameter("LanguageID", languageID) :
                new ObjectParameter("LanguageID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateInscriptions", inscriptionIDParameter, inscriptionNameParameter, dateParameter, dateIDParameter, locationParameter, locationIDParameter, languageParameter, languageIDParameter);
        }
    
        public virtual ObjectResult<DatesGet_Result> DatesGet(Nullable<int> dateID)
        {
            var dateIDParameter = dateID.HasValue ?
                new ObjectParameter("DateID", dateID) :
                new ObjectParameter("DateID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DatesGet_Result>("DatesGet", dateIDParameter);
        }
    
        public virtual ObjectResult<DatesGet_Result> DatesGetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DatesGet_Result>("DatesGetList");
        }
    
        public virtual ObjectResult<LanguageGet_Result> LanguageGet(Nullable<int> languageID)
        {
            var languageIDParameter = languageID.HasValue ?
                new ObjectParameter("LanguageID", languageID) :
                new ObjectParameter("LanguageID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LanguageGet_Result>("LanguageGet", languageIDParameter);
        }
    
        public virtual ObjectResult<LanguageGet_Result> LanguageGetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LanguageGet_Result>("LanguageGetList");
        }
    
        public virtual ObjectResult<LocationGet_Result> LocationGet(Nullable<int> locationID)
        {
            var locationIDParameter = locationID.HasValue ?
                new ObjectParameter("LocationID", locationID) :
                new ObjectParameter("LocationID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LocationGet_Result>("LocationGet", locationIDParameter);
        }
    
        public virtual ObjectResult<LocationGet_Result> LocationGetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LocationGet_Result>("LocationGetList");
        }
    
        public virtual ObjectResult<TranslationGet_Result> TranslationGet(Nullable<int> translationID)
        {
            var translationIDParameter = translationID.HasValue ?
                new ObjectParameter("TranslationID", translationID) :
                new ObjectParameter("TranslationID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TranslationGet_Result>("TranslationGet", translationIDParameter);
        }
    
        public virtual ObjectResult<TranslationGet_Result> TranslationGetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TranslationGet_Result>("TranslationGetList");
        }
    
        public virtual ObjectResult<ImagesGet_Result> ImagesGet(Nullable<int> imageID)
        {
            var imageIDParameter = imageID.HasValue ?
                new ObjectParameter("ImageID", imageID) :
                new ObjectParameter("ImageID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ImagesGet_Result>("ImagesGet", imageIDParameter);
        }
    
        public virtual ObjectResult<ImagesGet_Result> ImagesGetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ImagesGet_Result>("ImagesGetList");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<InscriptionTextGet_Result> InscriptionTextGet(Nullable<int> textID)
        {
            var textIDParameter = textID.HasValue ?
                new ObjectParameter("TextID", textID) :
                new ObjectParameter("TextID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InscriptionTextGet_Result>("InscriptionTextGet", textIDParameter);
        }
    
        public virtual ObjectResult<InscriptionTextGet_Result> InscriptionTextGetList(Nullable<int> inscriptionID)
        {
            var inscriptionIDParameter = inscriptionID.HasValue ?
                new ObjectParameter("InscriptionID", inscriptionID) :
                new ObjectParameter("InscriptionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InscriptionTextGet_Result>("InscriptionTextGetList", inscriptionIDParameter);
        }
    
        public virtual int DeleteInscriptionText(Nullable<int> textID)
        {
            var textIDParameter = textID.HasValue ?
                new ObjectParameter("TextID", textID) :
                new ObjectParameter("TextID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteInscriptionText", textIDParameter);
        }
    
        public virtual int InsertInscriptionText(Nullable<int> inscriptionID, Nullable<int> lineNumber, string text)
        {
            var inscriptionIDParameter = inscriptionID.HasValue ?
                new ObjectParameter("InscriptionID", inscriptionID) :
                new ObjectParameter("InscriptionID", typeof(int));
    
            var lineNumberParameter = lineNumber.HasValue ?
                new ObjectParameter("LineNumber", lineNumber) :
                new ObjectParameter("LineNumber", typeof(int));
    
            var textParameter = text != null ?
                new ObjectParameter("Text", text) :
                new ObjectParameter("Text", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertInscriptionText", inscriptionIDParameter, lineNumberParameter, textParameter);
        }
    
        public virtual int UpdateInscriptionText(Nullable<int> textID, Nullable<int> inscriptionID, string text, Nullable<int> lineNumber)
        {
            var textIDParameter = textID.HasValue ?
                new ObjectParameter("TextID", textID) :
                new ObjectParameter("TextID", typeof(int));
    
            var inscriptionIDParameter = inscriptionID.HasValue ?
                new ObjectParameter("InscriptionID", inscriptionID) :
                new ObjectParameter("InscriptionID", typeof(int));
    
            var textParameter = text != null ?
                new ObjectParameter("Text", text) :
                new ObjectParameter("Text", typeof(string));
    
            var lineNumberParameter = lineNumber.HasValue ?
                new ObjectParameter("LineNumber", lineNumber) :
                new ObjectParameter("LineNumber", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateInscriptionText", textIDParameter, inscriptionIDParameter, textParameter, lineNumberParameter);
        }
    
        public virtual ObjectResult<UserGet_Result> UserGet(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserGet_Result>("UserGet", userIDParameter);
        }
    
        public virtual int DeleteUser(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUser", userIDParameter);
        }
    
        public virtual int InsertUser(string name, string email, string password, Nullable<int> roleID)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUser", nameParameter, emailParameter, passwordParameter, roleIDParameter);
        }
    
        public virtual int UpdateUser(Nullable<int> userID, string name, string email, string password, Nullable<int> userRole)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var userRoleParameter = userRole.HasValue ?
                new ObjectParameter("UserRole", userRole) :
                new ObjectParameter("UserRole", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateUser", userIDParameter, nameParameter, emailParameter, passwordParameter, userRoleParameter);
        }
    
        public virtual ObjectResult<UserGet_Result> UserGetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserGet_Result>("UserGetList");
        }
    
        public virtual ObjectResult<UserInscriptionsGetList_Result> UserInscriptionsGetList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserInscriptionsGetList_Result>("UserInscriptionsGetList");
        }
    
        public virtual int InsertUserInscriptions(Nullable<int> userID, Nullable<int> inscriptionID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var inscriptionIDParameter = inscriptionID.HasValue ?
                new ObjectParameter("InscriptionID", inscriptionID) :
                new ObjectParameter("InscriptionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUserInscriptions", userIDParameter, inscriptionIDParameter);
        }
    
        public virtual int RemoveSavedInscription(Nullable<int> userID, Nullable<int> inscriptionID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var inscriptionIDParameter = inscriptionID.HasValue ?
                new ObjectParameter("InscriptionID", inscriptionID) :
                new ObjectParameter("InscriptionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RemoveSavedInscription", userIDParameter, inscriptionIDParameter);
        }
    
        public virtual ObjectResult<InscriptionsGet_Result> SelectRecent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InscriptionsGet_Result>("SelectRecent");
        }
    }
}
