using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Data.Models
{
	public class User
	{
		public String Manager { get; set; }
		public Boolean AdminFlag { get; set; }
		public String Password { get; set; }
		public String Login { get; set; }
		public Int32 AtttemptsQty { get; set; }
		public Boolean IsBlocked { get; set; }
	}
}
