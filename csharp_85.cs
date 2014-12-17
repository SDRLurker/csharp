using System;

namespace csharp_85
{
	[System.FlagsAttribute()]
	public enum Group
	{
		Users = 1,
		Supervisors = 2,
		Managers = 4,
		Administators = 8
	}
	public class User
	{
		public Group UserGroup{ get; set; }
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			User user1 = new User ();
			user1.UserGroup = Group.Managers | Group.Administators;
			Console.WriteLine ("user1.UserGroup : " + user1.UserGroup);
			/* user1.UserGroup : Managers, Administators */
			User user2 = new User ();
			user2.UserGroup = Group.Administators;
			Console.WriteLine ("user.UserGroup == Group.Administrators : " +
				(user2.UserGroup == Group.Administators));
			/* user.UserGroup == Group.Administrators : True */
			User user3 = new User ();
			user3.UserGroup = Group.Supervisors;
			Console.WriteLine ("user.UserGroup < Group.Administrators : " +
				(user3.UserGroup < Group.Administators));
			/* user.UserGroup < Group.Administrators : True */
		}
	}
}
