using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Abstract;

public interface IUnitOfWork : IAsyncDisposable
{
    IBakimLogRepository BakimLog {  get; }
    ICustomerRepository Customer {  get; }
    IEmployeeRepository Employee {  get; }
    IHizmetRepository Hizmet {  get; }
    IIsEmriRepository IsEmri {  get; }
    IIsEmriDetailRepository IsEmriDetail {  get; }
    IReportRepository Report {  get; }
    ISettingRepository Setting {  get; }
    IVehicleRepository Vehicle {  get; }
    Task<int> SaveAsync();
}
