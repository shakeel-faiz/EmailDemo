using System.Web;
using System.Collections.Generic;
using System.Threading;

namespace Aspose.Email.Cloud.Live.Demos.UI.Config
{
	/// <summary>
	/// Wrapper class for Aspose.Cloud Cloud Tools context access to Pages and controls
	/// </summary>
	public class AsposeEmailCloudContext : Context
	{
		/// <summary>
		/// The context data is directly picked up from the Application Thread's data slots, this is required to share the context between
		/// independent threads working for this application, e.g. AsyncHttpRequestHandlers and other assemblies as well, this will also 
		/// eliminate the need for extra copies and object cloning b/w assemblies
		/// </summary>
		/// <param name="hc"></param>
		internal AsposeEmailCloudContext(HttpContext hc) : base(hc) { Thread.SetData(Thread.GetNamedDataSlot(Configuration.ResourceFileSessionName + "ContextSlot"), hc); }
		private static AsposeEmailCloudContext atc;
		/// <summary>
		///  Use for internal syncing of the context
		/// </summary>
		internal static AsposeEmailCloudContext atcc { set { atc = value; } }
		internal static AsposeEmailCloudContext Current
		{
			get { return atc; }
		}

		internal new Dictionary<string, string> Resources
		{
			get { return base.Resources; }
		}
	}
}
