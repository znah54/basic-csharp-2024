using System.Collections.Immutable;

namespace ex13_linqs
{
    class Profile
    {
        private int age;
        public string Name { get; set; } // 자동 프로퍼티
        public int Height { get; set; } // 키에 -21억부터 + 21억
        public int Age {
            get => age;
            set
            {
                if (value >= 0 && value < 200) { age = value; }
                else { age = 20; }
            }
        }   // 나이에 -21억에서 + 21억까지        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ 테스트!");
            Profile[] arrProfiles =
            {
                new Profile{Name="정우성", Height = 186, Age = 49},
                new Profile{Name="이정재", Height = 184, Age = 49},
                new Profile{Name="김태희", Height = 158, Age = 46},
                new Profile{Name="김태희", Height = 158, Age = 46},
                new Profile{Name="김태희", Height = 158, Age = 46},
                new Profile{Name="김태희", Height = 158, Age = 46},
                new Profile{Name="김태희", Height = 158, Age = 46}


            };

            // LINQ 미사용
            List<Profile> profiles = new List<Profile>();
            foreach (Profile profile in arrProfiles)
            {
                if(profile.Height < 175)
                    profiles.Add(profile);
            }
            profiles.Sort(
                (profile1, profile2) =>
            {
                return profile1.Height - profile2.Height;
            });
            foreach(var profile in profiles)
            {
                Console.WriteLine($"{profile.Name}({profile.Age}세),{profile.Height}cm");
            }// LINQ를 사용하지 않으면 여기까지 15줄 코딩

            // LINQ사용하면
            Console.WriteLine("LINQ 사용");
            var profiles2 = from profile in arrProfiles
                            where profile.Height < 175
                            orderby profile.Height
                            select profile;
            foreach(var profile in profiles2)
            {
                Console.WriteLine($"{profile.Name}({profile.Age}세, {profile.Height}cm");
            } // LINQ를 사용하면 8줄 코딩.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n descending
                         select n;
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            // group by
            var groupProfiles = from p in arrProfiles
                                group p by p.Height < 175 into g
                                select new { GroupKey = g.Key, Profiles = g };
        }
    }
}
