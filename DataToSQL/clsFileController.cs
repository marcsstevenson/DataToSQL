#region Using directives

using System;
using System.IO;

#endregion

/// <summary>
/// Summary description for clsFileController
/// </summary>
public class clsFileController
{
	public clsFileController()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	#region Static Functions
	public static void WriteTextToFile(string strFilePath, string strText)
	{
		WriteTextToFile(strFilePath, strText, FileMode.OpenOrCreate);
	}
	public static void WriteTextToFile(string strFilePath, string strText, FileMode fileMode)
	{
		StreamWriter SW = File.AppendText(strFilePath);
		FileStream FS;
		char[] arrChar = strText.ToCharArray();

		try
		{
			if(FileExists(strFilePath))
			{
				SW.WriteLine(strText);
			}
			else
			{
				FS = File.Open(strFilePath, fileMode);

				for(int i = 0; i < strText.Length; i++)
				{
					FS.WriteByte(Convert.ToByte(arrChar[i]));
				}
				FS.Flush();
				FS.Close();
			}
		}
		catch
		{
		}
		finally
		{
			SW.Flush();
			SW.Close();
		}
	}
	public static bool DeleteFile(string strFilePath)
	{
		File.Delete(strFilePath);
		return true;
	}
	public static bool FileExists(string strFilePath)
	{
		return File.Exists(strFilePath);
	}
	public static string ReadFileToEnd(string strFilePath)
	{
		StreamReader SR;
		string strReturn = "";

		try
		{
			SR = File.OpenText(strFilePath);
			strReturn = SR.ReadToEnd();
			SR.Close();
		}
		catch
		{
		}

		return strReturn;
	}
	#endregion
}
