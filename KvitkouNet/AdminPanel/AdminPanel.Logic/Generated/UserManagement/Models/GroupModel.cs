// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AdminPanel.Logic.Generated.UserManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GroupModel
    {
        /// <summary>
        /// Initializes a new instance of the GroupModel class.
        /// </summary>
        public GroupModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupModel class.
        /// </summary>
        public GroupModel(string name = default(string), string description = default(string))
        {
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
