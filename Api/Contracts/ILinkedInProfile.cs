using DeltaShoppe.LinkedInClient.JsonDto;
using DeltaShoppe.LinkedInClient.JsonDto.FullProfile;

namespace DeltaShoppe.LinkedInClient.Api.Contracts
{
    public interface ILinkedInProfile
    {
        /// <summary>
        /// Get Basic profile for the currently logged in user
        /// </summary>
        /// <returns></returns>
        BasicProfile GetBasicProfile();

        /// <summary>
        /// Get basic profile for the user with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BasicProfile GetBasicProfile(int id);

        /// <summary>
        /// Get full profile for the currently logged in user
        /// </summary>
        /// <returns></returns>
        FullProfile GetFullProfile();

        /// <summary>
        /// Get full profile for the user with the specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FullProfile GetFullProfile(int id);
    }
}