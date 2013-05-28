using System;
using System.IO;
using System.Xml.Serialization;

namespace Core.Helpers
{
	/// <summary>
	/// Helper class to help with serialization
	/// </summary>
	public static class Serialization
	{
		#region Public Methods

		/// <summary>
		/// Serialize an object of to a string
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="objectToSerialize"></param>
		/// <returns></returns>
		public static string SerializeObjectToString<T>(T objectToSerialize)
		{
			string returnValue = string.Empty;

			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(objectToSerialize.GetType());
				StringWriter textWriter = new StringWriter();

				xmlSerializer.Serialize(textWriter, objectToSerialize);

				returnValue = textWriter.ToString();
			}
			catch (Exception ex)
			{
				returnValue = String.Format("Serialization Error: {0}", ex.Message);
			}

			return returnValue;
		}

		public static T DeSerializeStringToObject<T>(string stringToDeSerialize)
		{
			T returnValue;

			try
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

				using (StringReader sr = new StringReader(stringToDeSerialize))
				{
					returnValue = (T)xmlSerializer.Deserialize(sr);
				}
			}
			catch (Exception ex)
			{
				returnValue = default(T);
			}

			return returnValue;
		}

		#endregion
	}
}
