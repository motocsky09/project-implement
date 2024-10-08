using Server.Entities;

namespace Server.Repositories
{
    public interface IProfileRepository
    {
        List<Profile> GetProfiles();
        Profile GetProfileByUserName(string userName);
        void CreateProfile(Profile model);
        void UpdateProfile(Profile model);
        void DeleteProfile(int profileid);
        Profile CreateDefaultProfile(Profile model);
    }
}