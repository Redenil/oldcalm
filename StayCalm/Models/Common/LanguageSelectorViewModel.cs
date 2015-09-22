namespace StayCalm.Models.Common
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    /// <summary>
    /// View model used in LanguageSelector.cshtml
    /// </summary>
    public class LanguageSelectorViewModel
    {
        /// <summary>
        /// Gets the name of the current culture.
        /// </summary>
        /// <value>
        /// The name of the current culture.
        /// </value>
        public string CurrentCultureName { get; private set; }

        /// <summary>
        /// Gets the available cultures.
        /// </summary>
        /// <value>
        /// The available cultures.
        /// </value>
        public IEnumerable<SelectListItem> AvailableCultures { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageSelectorViewModel" /> class.
        /// </summary>
        internal LanguageSelectorViewModel()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="LanguageSelectorViewModel"/>.
        /// </summary>
        /// <param name="currentCulture">The current culture.</param>
        /// <param name="availableCultures">The available cultures.</param>
        /// <returns>An instance of <see cref="LanguageSelectorViewModel"/>.</returns>
        public static LanguageSelectorViewModel Create(string currentCulture, IEnumerable<string> availableCultures)
        {
            var model = new LanguageSelectorViewModel();

            model.CurrentCultureName = currentCulture;
            model.AvailableCultures =
                availableCultures.Select(
                    c => new SelectListItem { Value = c, Text = c });

            return model;
        }
    }

}