
using System.ComponentModel;
using System.Windows.Input;

namespace FinTechDesignExample.Pages.MainPage
{
	public class MainPageViewModel 
	{

		string lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
		string tr = "tr";
		private string username = "Ali";
		public string welcomeText { get { if (lang.Equals(tr)) return "Hosgeldin,\n" + username; else return "Welcome back,\n" + username; } set { username = value; } }
		public string balanceText { get { if (lang.Equals(tr)) return "BAKIYE"; else return "BALANCE"; } set { balanceText = value; } }

		private string cardTotalValue = "13 528,31";
		public string cardTotalText { get { if (lang.Equals(tr)) return cardTotalValue + " TL"; else return "$ " + cardTotalValue; } set { cardTotalValue = value; } }

		private string visaTotalValue = "5 312,05";
		public string visaTotalText { get { if (lang.Equals(tr)) return visaTotalValue + " TL"; else return "$ " + visaTotalValue; } set { visaTotalValue = value; } }
		public string budgetsText { get { if (lang.Equals(tr)) return "Butceler"; else return "Budgets"; } set { budgetsText = value; } }
		public string manageText { get { if (lang.Equals(tr)) return "Yonetim"; else return "Manage"; } set { manageText = value; } }
		public string travelText { get { if (lang.Equals(tr)) return "Seyahat"; else return "Travel"; } set { travelText = value; } }
		public string groceriesText { get { if (lang.Equals(tr)) return "Yemek"; else return "Groceries"; } set { groceriesText = value; } }

		private string leftValue = "828";

	

		public string leftText { get { if (lang.Equals(tr)) return leftValue + " TL kaldı"; else return "$ " + leftValue + " left"; } set { leftValue = value; } }

	
	}
}
