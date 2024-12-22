using Persistance.Contexts;
using Persistance.Repositories.Abstract;
using Persistance.Repositories.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Concrete;

public class UnitOfWork : IUnitOfWork
{
    private readonly zurafMTRContext _context;

    public UnitOfWork(zurafMTRContext context)
    {
        _context = context;
    }
    private BakimLogRepository _bakimLogRepository;
    private CustomerRepository _customerRepository;
    private EmployeeRepository _employeeRepository;
    private HizmetRepository _hizmetRepository;
    private IsEmriRepository _isEmriRepository;
    private IsEmriDetailRepository _isEmriDetailRepository;
    private ReportRepository _reportRepository;
    private SettingRepository _settingRepository;
    private VehicleRepository _vehicleRepository;
    public IBakimLogRepository BakimLog => _bakimLogRepository ??= new(_context);

    public ICustomerRepository Customer => _customerRepository ??= new(_context);

    public IEmployeeRepository Employee => _employeeRepository ??= new(_context);

    public IHizmetRepository Hizmet => _hizmetRepository ??= new(_context);

    public IIsEmriRepository IsEmri => _isEmriRepository ??= new(_context);

    public IIsEmriDetailRepository IsEmriDetail => _isEmriDetailRepository ??= new(_context);

    public IReportRepository Report => _reportRepository ??= new(_context);

    public ISettingRepository Setting => _settingRepository ??= new(_context);

    public IVehicleRepository Vehicle => _vehicleRepository ??= new(_context);

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
