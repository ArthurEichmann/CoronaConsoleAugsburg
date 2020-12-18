using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaConsole
{
    public class CoronaObject
    {
        public class UniqueIdField
        {
            public string name { get; set; }
            public bool isSystemMaintained { get; set; }
        }

        public class GeometryProperties
        {
            public string shapeAreaFieldName { get; set; }
            public string shapeLengthFieldName { get; set; }
            public string units { get; set; }
        }

        public class SpatialReference
        {
            public int wkid { get; set; }
            public int latestWkid { get; set; }
        }

        public class Field
        {
            public string name { get; set; }
            public string type { get; set; }
            public string alias { get; set; }
            public string sqlType { get; set; }
            public object domain { get; set; }
            public object defaultValue { get; set; }
            public int? length { get; set; }
        }

        public class Attributes
        {
            public int OBJECTID { get; set; }
            public int ADE { get; set; }
            public int GF { get; set; }
            public int BSG { get; set; }
            public string RS { get; set; }
            public string AGS { get; set; }
            public string SDV_RS { get; set; }
            public string GEN { get; set; }
            public string BEZ { get; set; }
            public int IBZ { get; set; }
            public string BEM { get; set; }
            public string NBD { get; set; }
            public string SN_L { get; set; }
            public string SN_R { get; set; }
            public string SN_K { get; set; }
            public string SN_V1 { get; set; }
            public string SN_V2 { get; set; }
            public string SN_G { get; set; }
            public string FK_S3 { get; set; }
            public string NUTS { get; set; }
            public string RS_0 { get; set; }
            public string AGS_0 { get; set; }
            public string WSK { get; set; }
            public int EWZ { get; set; }
            public double KFL { get; set; }
            public string DEBKG_ID { get; set; }
            public double Shape__Area { get; set; }
            public double Shape__Length { get; set; }
            public double death_rate { get; set; }
            public int cases { get; set; }
            public int deaths { get; set; }
            public double cases_per_100k { get; set; }
            public double cases_per_population { get; set; }
            public string BL { get; set; }
            public string BL_ID { get; set; }
            public string county { get; set; }
            public string last_update { get; set; }
            public double cases7_per_100k { get; set; }
            public object recovered { get; set; }
            public int EWZ_BL { get; set; }
            public double cases7_bl_per_100k { get; set; }
            public int cases7_bl { get; set; }
            public int death7_bl { get; set; }
            public int cases7_lk { get; set; }
            public int death7_lk { get; set; }
            public string cases7_per_100k_txt { get; set; }
        }

        public class Geometry
        {
            public List<List<List<double>>> rings { get; set; }
        }

        public class Feature
        {
            public Attributes attributes { get; set; }
            public Geometry geometry { get; set; }
        }

        public class root
        {
            public string objectIdFieldName { get; set; }
            public UniqueIdField uniqueIdField { get; set; }
            public string globalIdFieldName { get; set; }
            public GeometryProperties geometryProperties { get; set; }
            public string geometryType { get; set; }
            public SpatialReference spatialReference { get; set; }
            public List<Field> fields { get; set; }
            public List<Feature> features { get; set; }
        }
    }
}
