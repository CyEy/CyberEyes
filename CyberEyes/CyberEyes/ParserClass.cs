using System.Collections.Generic;

namespace CyberEyes
{
	public class RImage
	{
		public string content { get; set; }
	}

	public class Feature
	{
		public string type { get; set; }
		public int maxResults { get; set; }
	}

	public class Request
	{
		public RImage image { get; set; }
		public List<Feature> features { get; set; }
	}

	public class RootObject
	{
		public List<Request> requests { get; set; }
	}

	public class LabelAnnotation
	{
		public string mid { get; set; }
		public string description { get; set; }
		public double score { get; set; }
	}

	public class Response
	{
		public List<LabelAnnotation> labelAnnotations { get; set; }
	}

	public class RRootObject
	{
		public List<Response> responses { get; set; }
	}
}
