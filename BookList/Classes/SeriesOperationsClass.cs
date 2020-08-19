using System.Diagnostics;
using System.Reflection;
using System.Text;
using BookList.Collections;

namespace BookList.Classes
{

    /// <summary>
    /// Series operations class.
    /// </summary>
    public class SeriesOperationsClass
    {
        /// <summary>
        ///     Deceleration of Message Box Object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        ///     Declare validation class Object.
        /// </summary>
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesOperationsClass"/> class.
        /// </summary>
        public SeriesOperationsClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Formats the book Series, Title, Volume data.
        /// </summary>
        /// <param name="series">The Series name.</param>
        /// <param name="title">The Title name.</param>
        /// <param name="volume">The Volume number.</param>
        /// <returns></returns>
        public string FormatBookSeriesData(string series, string title, string volume)
        {
            var sb = new StringBuilder(title.Trim());
            sb.Append("(");
            sb.Append(series.Trim());
            sb.Append(")");
            sb.Append(volume.Trim());

            return sb.ToString();
        }
    }
}
