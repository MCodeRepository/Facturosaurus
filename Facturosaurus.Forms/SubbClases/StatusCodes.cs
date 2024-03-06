using System.Collections.Generic;

namespace Facturosaurus.Forms.SubbClases
{
    internal static class StatusCodes
    {
        static public Dictionary<int, string> Status = new Dictionary<int, string>()
        {
            { 200, "OK" },
            { 201, "Created" },
            { 204, "No Content" },
            { 400, "Bad Request" },
            { 401, "Brak zalogowanego użytkownika" },
            { 403, "Nie posiadasz uprawnień do wydonania danej operacji" },
            { 404, "Not Found" },
            { 500, "Internal Server Error" },

            { 1000, "Błąd API" },
            { 1001 , "Brak konfiguracji serwisu API" },
            { 1002 , "Brak połączenia z serwisem" },

            { 1100 , "Błąd pobierania listy użytkowników" },
            { 1101 , "Błąd pobierania użytkownika" },
            { 1102 , "Błąd pobierania listy ról użytkowników" },
            { 1103 , "Błąd usuwania użytkownika" },
            { 1104 , "Błąd rejestracji nowego użytkownika" },
            { 1105 , "Brak nowego użytkownika" },
            { 1106 , "Użytkownik o podanym adresie e-mail już istnieje." },
            { 1107 , "Błąd modyfikacji użytkownika." },
            { 1108 , "Brak użytkownika do modyfikacji" },
            { 1109 , "Błąd aktualizacji nowego hasła" },
            { 1110 , "Brak nowego hasła użytkownika" },
            { 1111 , "Podany adres email jest już przypisany do innego użytkownika" },
            { 1112 , "Błąd logowania" },
            { 1113 , "Brak danych do logowania" },
            { 1114 , "Wyspąpił błąd podczas sprawdzania połączenia" },
            { 1115 , "Podane hasło lub email są niepoprawne." },

            { 1200 , "Błąd pobierania aktualnych danych firmy" },
            { 1201 , "Błąd pobierania aktualnych danych firmy na dany dzień" },
            { 1202 , "Błąd aktualizacji szczegółowych danych firmy" },
            { 1203 , "Brak nowych danych firmy" },
            { 1204 , "Brak danych firmy na dzień wystawiania faktury" },

            { 1300 , "Błąd pobierania listy faktur" },
            { 1301 , "Błąd tworzenia nowej faktury" },
            { 1302 , "Brak nowej faktury" },
            { 1303 , "Błąd modyfikacji faktury" },
            { 1304 , "Brak faktury do modyfikacji" },

            { 1400 , "Błąd pobierania listy kontrahentów" },
            { 1401 , "Kontrahent o podanym numerze NIP już istnieje." },
            { 1402 , "Błąd tworzenia kontrahenta." },
            { 1403 , "Brak nowego kontrahenta" },

            { 1404 , "Błąd modyfikacji kontrahenta" },
            { 1405 , "Brak kontrahenta do modyfikacji" },
            { 1406 , "Błąd usuwania kontrahenta" },
            { 1407 , "Brak kontrahenta do usunięcia" },
        };

        public static string GetErrorInfo(int code)
        {
            string value = $"Wystąpił błąd [{code}]";
            Status.TryGetValue(code, out value);

            return value;
        }
    }
}
