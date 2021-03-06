﻿using ServiceStack;

namespace Solcast.ServiceModel
{
    [Route("/radiation/estimated_actuals", "GET")]
    public class GetRadiationEstimatedActuals
        : IReturn<GetRadiationEstimatedActualsResponse>
    {
        [ApiMember(Name="latitude", IsRequired=true)]
        public virtual double Latitude { get; set; }

        [ApiMember(Name="longitude", IsRequired=true)]
        public virtual double Longitude { get; set; }
    }
}