//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DPTS.Domain.Email
//{
//    class IEmailService
//    {
//    }
//}
 using System.Collections.Generic;
 using DPTS.Domain.Entities;

namespace DPTS.Domain.Email
{
    /// <summary>
    /// Country service interface
    /// </summary>
    public partial interface IEmailService
    {
        /// <summary>
        /// Deletes a email
        /// </summary>
        /// <param name="email">Email</param>
    //y    void DeleteEmailEmail email);

        /// <summary>
        /// Gets all countries
        /// </summary>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>Countries</returns>
        IList<IEmailService> GetAllEmailServiceses(bool showHidden = false);

        /// <summary>
        /// Gets a country 
        /// </summary>
        /// <param name="emailId">Country identifier</param>
        /// <returns>Country</returns>
        IEmailService GetEmailServiceById(int emailId);

        /// <summary>
        /// Get countries by identifiers
        /// </summary>
        /// <param name="emailIds">Country identifiers</param>
        /// <returns>Countries</returns>
        IList<IEmailService> GetEmailServicesesByIds(int[] emailIds);

        /// <summary>
        /// Gets a country by two letter ISO code
        /// </summary>
        /// <param name="twoLetterIsoCode">Country two letter ISO code</param>
        /// <returns>Country</returns>
        Country GetEmailByTwoLetterIsoCode(string twoLetterIsoCode);

        /// <summary>
        /// Gets a email by three letter ISO code
        /// </summary>
        /// <param name="threeLetterIsoCode">Country three letter ISO code</param>
        /// <returns>Country</returns>
        Country GetEmailCountryByThreeLetterIsoCode(string threeLetterIsoCode);

        /// <summary>
        /// Inserts a email
        /// </summary>
        /// <param name="email">Email</param>
        void InsertEmail(IEmailService email);

        /// <summary>
        /// Updates the country
        /// </summary>
        /// <param name="email">Email</param>
        void UpdateEmail(IEmailService email);
    }
}
