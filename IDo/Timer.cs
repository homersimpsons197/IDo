using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDo
{

    internal class Timer
    {
        UserControl2 uc2 = new UserControl2();
        UserControl3 uc3 = new UserControl3();
        UserControl4 uc4 = new UserControl4();
        PostActionController pAC = new PostActionController();
        FollowActionController fAC = new FollowActionController();
        UnfollowActionController uAC = new UnfollowActionController();

        public async void PostStart()
        {
            do
            {
                await Task.Delay(uc2.GetIntervalPost());
                pAC.Post();
            }
            while (true);
        }

        public async void FollowStart()
        {
            do
            {
                await Task.Delay(uc3.GetIntervalFollow());
                fAC.Follow();
            }
            while (true);

        }

        public async void UnfollowStart()
        {
            do
            {
                await Task.Delay(uc4.GetIntervalUnfollow());
                uAC.Unfollow();
            }
            while(true);
        }
    }
}
