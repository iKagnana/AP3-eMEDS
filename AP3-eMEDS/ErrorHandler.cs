using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP3_eMEDS
{
    // enum with type error 
    public enum typeError
    {
        NoConnection,
        InvalidCredentials,
        UnknownError,
        CannotDelete,
        OnlyGroupBy, 
        NoError

    }
    public class ErrorHandler
    {
        public typeError type { get; set; }

        public ErrorHandler(MySqlException e) {
            GetErrorType(e);
        }

        public string GetMessageError()
        {
            switch (this.type)
            {
                case typeError.CannotDelete:
                    return "Vous ne pouvez pas supprimer cet élément";
                case typeError.NoConnection:
                    return "Aucune connexion à la base de données";
                case typeError.InvalidCredentials:
                    return "Identifiants liés à la base de données invalides";
                case typeError.UnknownError:
                    return "Une erreur non-identifiable s'est produite";
                case typeError.OnlyGroupBy:
                    return "Erreur avec la configuration sql 'only_full_group_by'";
                default:
                    return "";
            }
        }

        public void GetErrorType(MySqlException error)
        {
            Console.WriteLine($"GetErrorType ErrorHandler error code : {error.Number}");
            switch (error.Number)
            {
                case 2003:
                case 2005:
                    this.type = typeError.NoConnection;
                    break;
                case 1045:
                case 2009:
                    this.type = typeError.InvalidCredentials;
                    break;
                case 1451:
                    this.type = typeError.CannotDelete;
                    break;
                case 3088:
                    this.type = typeError.OnlyGroupBy;
                    break;
                default:
                    this.type = typeError.UnknownError;
                    break;
            }
        }

    }
}
