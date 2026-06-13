using Microsoft.AspNetCore.Html;
using WebApplication2lab2.Models;
using WebApplication2lab2.Models;

namespace WebApplication2lab2.Helpers
{
    public static class BookHelpers
    {
        public static IHtmlContent ShowBooksList(Book[] list, int booksCount)
        {
            var sb = new System.Text.StringBuilder();

            sb.Append("<table border='1' cellpadding='5'>");
            sb.Append("<tr><th>Название</th><th>Автор</th><th>Год</th><th>Цена</th><th>Дата поступления</th></tr>");

            foreach (var book in list)
            {
                if (book != null)
                {
                    sb.Append("<tr>");
                    sb.Append("<td>" + book.Title + "</td>");
                    sb.Append("<td>" + book.Author + "</td>");
                    sb.Append("<td>" + book.Year + "</td>");
                    sb.Append("<td>" + book.Price + "</td>");
                    sb.Append("<td>" + book.ArrivalDate.ToShortDateString() + "</td>");
                    sb.Append("</tr>");
                }
            }

            sb.Append("</table>");
            sb.Append("<p> Всего книг: " + booksCount + "</p>");

            return new HtmlString(sb.ToString());
        }
    }
}