namespace MapApi.DB{
    public class IntegerSpiralDatabaseSettings:IIntegerSpiralDatabaseSettings{
        public string CollectionName{get;set;}="layout";
        public string ConnectionString {get;set;}="";
        public string DatabaseName {get;set;}="IntegerSpiral";
    }
    
}
