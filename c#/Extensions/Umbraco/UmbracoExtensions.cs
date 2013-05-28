using umbraco.interfaces;
using umbraco.MacroEngines;
using umbraco.NodeFactory;
using Umbraco.Core.Models;

namespace Core.Extensions
{
	/// <summary>
	/// Extensions to work with Umbraco
	/// </summary>
	public static class UmbracoExtensions
	{
		#region Public Methods

		/// <summary>
		/// Gets a property value from Umbraco when a string is expected, nulls are returned as empty string
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static string GetStringPropertyValue(this DynamicNode node, string alias)
		{
			string returnValue = string.Empty;

			if (node != null && node.Id != 0)
			{
				var prop = node.GetProperty(alias);

				if (prop != null)
				{
					returnValue = prop.Value;
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Gets a property value from Umbraco when a string is expected, nulls are returned as empty string
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static string GetStringPropertyValue(this IPublishedContent node, string alias)
		{
			string returnValue = string.Empty;

			IPublishedContentProperty prop = node.GetProperty(alias);

			if (prop != null)
			{
				if (prop.Value != null)
				{
					if (prop.Value is string)
					{
						returnValue = prop.Value.ToString();
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Gets a property value from Umbraco when a string is expected, nulls are returned as empty string
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static string GetStringPropertyValue(this Node node, string alias)
		{
			string returnValue = string.Empty;

			IProperty prop = node.GetProperty(alias);

			if (prop != null)
			{
				if (prop.Value != null)
				{
					if (prop.Value is string)
					{
						returnValue = prop.Value.ToString();
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Gets a property value from Umbraco when an int is expected, nulls are returned as -1
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static int GetIntPropertyValue(this DynamicNode node, string alias)
		{
			int returnValue = -1;

			if (node != null && node.Id != 0)
			{
				var prop = node.GetProperty(alias);

				if (prop != null)
				{
					int intValue = -1;

					if (int.TryParse(prop.Value, out intValue))
					{
						returnValue = intValue;
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Gets a property value from Umbraco when an int is expected, nulls are returned as -1
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static int GetIntPropertyValue(this IPublishedContent node, string alias)
		{
			int returnValue = -1;
			int tempint = -1;

			IPublishedContentProperty prop = node.GetProperty(alias);

			if (prop != null)
			{
				if (prop.Value != null)
				{
					if (prop.Value is string)
					{
						if (int.TryParse(prop.Value.ToString(), out tempint))
						{
							returnValue = int.Parse(prop.Value.ToString());
						}
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Gets a property value from Umbraco when an int is expected, nulls are returned as -1
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static int GetIntPropertyValue(this Node node, string alias)
		{
			int returnValue = -1;
			int tempint = -1;

			IProperty prop = node.GetProperty(alias);

			if (prop != null)
			{
				if (prop.Value != null)
				{
					if (int.TryParse(prop.Value.ToString(), out tempint))
					{
						returnValue = int.Parse(prop.Value.ToString());
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Gets a property value from Umbraco when an bool is expected, nulls are returned as false
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static bool GetBoolPropertyValue(this DynamicNode node, string alias)
		{
			bool returnValue = false;

			if (node != null && node.Id != 0)
			{
				var prop = node.GetProperty(alias);

				if (prop != null)
				{
					if (prop.Value == "1")
					{
						returnValue = true;
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Gets a property value from Umbraco when an bool is expected, nulls are returned as false
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static bool GetBoolPropertyValue(this IPublishedContent node, string alias)
		{
			bool returnValue = false;

			IPublishedContentProperty prop = node.GetProperty(alias);

			if (prop != null)
			{
				if (prop.Value != null)
				{
					if (prop.Value is string)
					{
						if (prop.Value.ToString() == "1")
						{
							returnValue = true;
						}
					}
				}
			}

			return returnValue;
		}

		/// <summary>
		/// Gets a property value from Umbraco when an bool is expected, nulls are returned as false
		/// </summary>
		/// <param name="node"></param>
		/// <param name="alias"></param>
		/// <returns></returns>
		public static bool GetBoolPropertyValue(this Node node, string alias)
		{
			bool returnValue = false;

			IProperty prop = node.GetProperty(alias);

			if (prop != null)
			{
				if (prop.Value != null)
				{
					if (prop.Value is string)
					{
						if (prop.Value.ToString() == "1")
						{
							returnValue = true;
						}
					}
				}
			}

			return returnValue;
		}

		#endregion
	}
}
