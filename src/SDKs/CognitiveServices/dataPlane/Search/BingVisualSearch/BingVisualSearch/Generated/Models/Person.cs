// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.VisualSearch.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines a person.
    /// </summary>
    public partial class Person : Thing
    {
        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        public Person()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="readLink">The URL that returns this resource.</param>
        /// <param name="webSearchUrl">The URL To Bing's search result for this
        /// item.</param>
        /// <param name="name">The name of the thing represented by this
        /// object.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        /// <param name="image">An image of the item.</param>
        /// <param name="description">A short description of the item.</param>
        /// <param name="alternateName">An alias for the item</param>
        /// <param name="bingId">An ID that uniquely identifies this
        /// item.</param>
        /// <param name="jobTitle">The person's job title.</param>
        /// <param name="twitterProfile">The URL of the person's twitter
        /// profile.</param>
        public Person(string id = default(string), string readLink = default(string), string webSearchUrl = default(string), string name = default(string), string url = default(string), ImageObject image = default(ImageObject), string description = default(string), string alternateName = default(string), string bingId = default(string), string jobTitle = default(string), string twitterProfile = default(string))
            : base(id, readLink, webSearchUrl, name, url, image, description, alternateName, bingId)
        {
            JobTitle = jobTitle;
            TwitterProfile = twitterProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the person's job title.
        /// </summary>
        [JsonProperty(PropertyName = "jobTitle")]
        public string JobTitle { get; private set; }

        /// <summary>
        /// Gets the URL of the person's twitter profile.
        /// </summary>
        [JsonProperty(PropertyName = "twitterProfile")]
        public string TwitterProfile { get; private set; }

    }
}
