// <auto-generated />
namespace services.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class datasetconfig : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(datasetconfig));
        
        string IMigrationMetadata.Id
        {
            get { return "201407111808008_dataset-config"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}