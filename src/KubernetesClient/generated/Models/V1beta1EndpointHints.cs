// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EndpointHints provides hints describing how an endpoint should be
    /// consumed.
    /// </summary>
    public partial class V1beta1EndpointHints
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1EndpointHints class.
        /// </summary>
        public V1beta1EndpointHints()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1EndpointHints class.
        /// </summary>
        /// <param name="forZones">forZones indicates the zone(s) this endpoint
        /// should be consumed by to enable topology aware routing. May contain
        /// a maximum of 8 entries.</param>
        public V1beta1EndpointHints(IList<V1beta1ForZone> forZones = default(IList<V1beta1ForZone>))
        {
            ForZones = forZones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets forZones indicates the zone(s) this endpoint should be
        /// consumed by to enable topology aware routing. May contain a maximum
        /// of 8 entries.
        /// </summary>
        [JsonProperty(PropertyName = "forZones")]
        public IList<V1beta1ForZone> ForZones { get; set; }

    }
}
