namespace Microsoft.AspNet.WebApi.HelpPage.Models
{
    using System;

    /// <summary>
    /// A generic value.
    /// </summary>
    public class Value
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Value"/> class.
        /// </summary>
        public Value()
        {
            this.Id = new Random().Next();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Value"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public Value(string text) 
            : this()
        {
            this.Text = text;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>The text.</value>
        public string Text { get; set; }
    }
}