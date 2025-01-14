using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CApexResource : CMeshTypeResource
	{
#if NGE_VERSION
        [Ordinal(1)] [RED("apexBinaryAsset", 100,0)] 		public CByteArray ApexBinaryAsset { get; set;}
#else
		[Ordinal(1)] [RED("apexBinaryAsset", 95,0)] 		public CByteArray ApexBinaryAsset { get; set;}
#endif

		[Ordinal(2)] [RED("apexMaterialNames", 2,0)] 		public CArray<CString> ApexMaterialNames { get; set;}

		[Ordinal(3)] [RED("shadowDistance")] 		public CFloat ShadowDistance { get; set;}

		public CApexResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CApexResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
