// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IDataSource.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// Football_Football interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IFootball_Football
    {
		ObservableCollection<Entities.FootballSchema> GetData(int pageNumber = 0);
		ObservableCollection<Entities.FootballSchema> Search(FilterSpecification filter);
		bool HasPrevious(Entities.FootballSchema current);
		bool HasNext(Entities.FootballSchema current);
		Entities.FootballSchema Previous(Entities.FootballSchema current);
		Entities.FootballSchema Next(Entities.FootballSchema current);
    }
}
