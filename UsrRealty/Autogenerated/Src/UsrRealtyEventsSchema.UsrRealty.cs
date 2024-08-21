namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8821ee96-bd2c-4c79-8fec-0f266eabb7f2");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1bf2596f-fc1f-459b-ab56-3397007fd6d8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,110,219,48,12,189,23,232,63,16,198,14,54,16,8,237,117,221,10,44,89,54,20,40,182,161,118,122,25,118,80,100,198,213,32,75,134,40,167,203,134,254,251,40,203,89,82,167,3,202,139,45,242,241,241,61,130,86,182,72,157,84,8,21,122,47,201,109,130,88,56,187,209,77,239,101,208,206,158,159,253,57,63,3,142,158,180,109,160,220,81,192,246,234,56,117,220,216,182,206,254,183,232,81,44,109,208,65,35,189,6,35,150,91,180,97,15,253,62,164,119,67,238,86,179,8,139,62,47,213,3,182,242,11,123,128,247,144,173,200,223,161,52,97,151,21,63,82,83,215,175,141,86,160,140,36,130,84,123,129,6,222,194,92,18,190,80,73,44,227,2,142,8,221,150,37,235,26,97,235,116,13,95,109,41,183,108,36,119,235,159,168,2,16,218,26,253,12,18,225,28,55,236,106,160,253,224,27,2,44,14,116,71,204,49,214,172,66,252,99,219,211,96,113,245,28,150,120,193,15,126,216,120,158,18,69,106,152,128,107,84,186,149,6,58,175,85,220,82,234,18,159,49,84,187,14,235,133,51,125,107,239,165,233,241,221,8,189,206,227,38,191,69,252,170,252,152,77,167,235,13,228,137,236,26,46,47,246,81,60,7,77,140,197,64,113,67,11,105,21,26,172,89,71,240,61,50,243,41,142,130,143,71,193,103,73,178,193,10,219,206,200,16,149,91,124,132,91,167,164,209,191,229,218,96,57,224,242,209,207,138,208,243,221,90,222,63,31,173,184,67,114,189,87,12,114,158,89,102,167,99,98,28,46,38,157,90,54,131,236,100,2,137,97,59,55,84,57,55,215,77,122,101,133,168,220,168,160,120,133,13,150,159,18,226,147,243,173,12,249,196,30,15,190,20,23,243,55,39,219,142,17,30,188,123,28,236,47,127,41,236,162,193,125,255,20,254,116,120,142,191,252,121,250,11,85,91,137,91,229,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1b770230-369f-edec-1ef1-7ce9a85a1ac3"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("1bf2596f-fc1f-459b-ab56-3397007fd6d8"),
				CreatedInSchemaUId = new Guid("8821ee96-bd2c-4c79-8fec-0f266eabb7f2"),
				ModifiedInSchemaUId = new Guid("8821ee96-bd2c-4c79-8fec-0f266eabb7f2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8821ee96-bd2c-4c79-8fec-0f266eabb7f2"));
		}

		#endregion

	}

	#endregion

}

