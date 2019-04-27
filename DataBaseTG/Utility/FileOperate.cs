using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public static class FileOperate
{

    /// <summary>
    /// 文件写入内容
    /// </summary>
    /// <param name="content"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    public static void FileWrite(List<string> list, string path)
    {
        using (FileStream myfs = new FileStream(path, FileMode.Create))
        {
            using (StreamWriter mySw = new StreamWriter(myfs))
            {
                foreach (string row in list)
                {
                    mySw.WriteLine(row);
                }
            }
        }
    }

    /// <summary>
    /// 读取文件内容
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static string FileReader(string path)
    {
        string content = "";
        using (FileStream myfs = new FileStream(path, FileMode.Open))
        {
            using (StreamReader mySr = new StreamReader(myfs))
            {
                content = mySr.ReadToEnd();
            }
        }
        return content;
    }

    public static string SqlServerTypeToCType(string type)
    {
        string cSharpType = string.Empty;
        switch (type.ToLower())
        {
            case "bit":
                cSharpType = "bool";
                break;
            case "tinyint":
                cSharpType = "byte";
                break;
            case "smallint":
                cSharpType = "short";
                break;
            case "int":
                cSharpType = "int";
                break;
            case "bigint":
                cSharpType = "long";
                break;
            case "real":
                cSharpType = "float";
                break;
            case "float":
                cSharpType = "double";
                break;
            case "smallmoney":
            case "money":
            case "decimal":
            case "numeric":
                cSharpType = "decimal";
                break;
            case "char":
            case "varchar":
            case "nchar":
            case "nvarchar":
            case "text":
            case "ntext":
                cSharpType = "string";
                break;
            case "samlltime":
            case "date":
            case "smalldatetime":
            case "datetime":
            case "datetime2":
            case "datetimeoffset":
                cSharpType = "System.DateTime";
                break;
            case "timestamp":
            case "image":
            case "binary":
            case "varbinary":
                cSharpType = "byte[]";
                break;
            case "uniqueidentifier":
                cSharpType = "System.Guid";
                break;
            case "variant":
            case "sql_variant":
                cSharpType = "object";
                break;
            default:
                cSharpType = "string";
                break;
        }
        return cSharpType;
    }

    public static string MysqlTypeToCType(string type)
    {
        string cSharpType = string.Empty;
        switch (type.ToLower())
        {
            case "bit":
                cSharpType = "bool";
                break;
            case "tinyint":
                cSharpType = "byte";
                break;
            case "smallint":
                cSharpType = "short";
                break;
            case "int":
                cSharpType = "int";
                break;
            case "bigint":
                cSharpType = "long";
                break;
            case "real":
                cSharpType = "float";
                break;
            case "float":
                cSharpType = "double";
                break;
            case "smallmoney":
            case "money":
            case "decimal":
            case "numeric":
                cSharpType = "decimal";
                break;
            case "char":
            case "varchar":
            case "nchar":
            case "nvarchar":
            case "text":
            case "ntext":
                cSharpType = "string";
                break;
            case "samlltime":
            case "date":
            case "smalldatetime":
            case "datetime":
            case "datetime2":
            case "datetimeoffset":
                cSharpType = "System.DateTime";
                break;
            case "timestamp":
            case "image":
            case "binary":
            case "varbinary":
                cSharpType = "byte[]";
                break;
            case "uniqueidentifier":
                cSharpType = "System.Guid";
                break;
            case "variant":
            case "sql_variant":
                cSharpType = "object";
                break;
            default:
                cSharpType = "string";
                break;
        }
        return cSharpType;
    }
}

