using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPTS.Domain.Core;
using DPTS.Domain.Entities;

namespace DPTS.Services.Email
{
    class EmailService
    {
         #region Fields

        private readonly IRepository<EmailService> _emailRepository;

        #endregion

        #region Ctor

        public EmailService(IRepository<EmailService> emailRepository)
        {
            _emailRepository = emailRepository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes a email
        /// </summary>
        /// <param name="email">Email</param>
        public virtual void DeleteCountry(EmailService email)
        {
            if (email == null)
                throw new ArgumentNullException("email");

            _emailRepository.Delete(email);

        }
        /// <summary>
        /// Gets all countries
        /// </summary>
        /// <param name="languageId">Language identifier. It's used to sort countries by localized names (if specified); pass 0 to skip it</param>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>Countries</returns>
        //public virtual IList<EmailService> GetAllEmailes(bool showHidden = false)
        //{
        //    var query = _emailRepository.Table;
        //    if (!showHidden)
        //        query = query.Where(c => c.Published);
        //    query = query.OrderBy(c => c.DisplayOrder).ThenBy(c => c.Name);

        //    var emailseses = query.ToList();
        //        return emailseses;
        //}

        /// <summary>
        /// Gets a email 
        /// </summary>
        /// <param name="emailId">Email identifier</param>
        /// <returns>Country</returns>
        public virtual EmailService GetCountryById(int emailId)
        {
            if (emailId == 0)
                return null;

            return _emailRepository.GetById(emailId);
        }

        /// <summary>
        /// Get countries by identifiers
        /// </summary>
        /// <param name="emailIds">Country identifiers</param>
        /// <returns>Countries</returns>
        //public virtual IList<EmailService> GetEmailServicesesByIds(int[] emailIds)
        //{
        //    if (emailIds == null || emailIds.Length == 0)
        //        return new List<EmailService>();

        //    var query = from c in _emailRepository.Table
        //                where emailIds.Contains(c.Id)
        //                select c;
        //    var emailes = query.ToList();
        //    //sort by passed identifiers
        //    var sortedCountries = new List<EmailService>();
        //    foreach (int id in emailIds)
        //    {
        //        var email = emailes.Find(x => x.Id == id);
        //        if (email != null)
        //            sortedEmailes.Add(email);
        //    }
        //    return sortedEmailes;
        //}

        /// <summary>
        /// Gets a country by two letter ISO code
        /// </summary>
        /// <param name="twoLetterIsoCode">Country two letter ISO code</param>
        /// <returns>Country</returns>
        //public virtual Count GetEmailByTwoLetterIsoCode(string twoLetterIsoCode)
        //{
        //    if (String.IsNullOrEmpty(twoLetterIsoCode))
        //        return null;

        //    var query = from c in _emailRepository.Table
        //                where c.TwoLetterIsoCode == twoLetterIsoCode
        //                select c;
        //    var email = query.FirstOrDefault();
        //    return email;
        //}

       
        //public virtual EmailService GetEmailByThreeLetterIsoCode(string threeLetterIsoCode)
        //{
        //    if (String.IsNullOrEmpty(threeLetterIsoCode))
        //        return null;

        //    var query = from c in _emailRepository.Table
        //   //y             where c.ThreeLetterIsoCode == threeLetterIsoCode
        //                select c;
        // //y   var email = query.FirstOrDefault();
        //    return email;
        //}

        /// <summary>
        /// Inserts a email
        /// </summary>
        /// <param name="email">Email</param>
        public virtual void InsertEmail(EmailService email)
        {
           //y if (EmailService == null)
                throw new ArgumentNullException("email");

            _emailRepository.Insert(email);
        }

        /// <summary>
        /// Updates the country
        /// </summary>
        /// <param name="email">Email</param>
        public virtual void UpdateCountry(EmailService email)
        {
            if (email == null)
                throw new ArgumentNullException("email");

            _emailRepository.Update(email);
        }
        #endregion

    }
}
