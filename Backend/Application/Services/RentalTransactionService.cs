    // RentalTransactionService for handling rental requests with approval workflow
    public class RentalTransactionService
    {
        private readonly List<RentalTransaction> _rentalTransactions;
        private readonly VehicleService _vehicleService;
        private readonly UserService _userService;

        public RentalTransactionService(VehicleService vehicleService, UserService userService)
        {
            _rentalTransactions = new List<RentalTransaction>();
            _vehicleService = vehicleService;
            _userService = userService;
        }

        public async Task<string> CreateRentalRequestAsync(Guid customerId, Guid vehicleId, DateTime startDate, DateTime endDate)
        {
            var customer = await _userService.GetCustomerByIdAsync(customerId);
            if (customer == null)
            {
                return "Customer not found.";
            }

            var vehicle = await _vehicleService.GetVehicleByIdAsync(vehicleId);
            if (vehicle == null || !vehicle.IsAvailable)
            {
                return "Vehicle not available.";
            }

            if (customer.IsCorporate && customer.Role == CustomerRole.CorporateRenter && vehicle.Type != VehicleType.Car)
            {
                return "Corporate Renters can only rent Cars.";
            }

            var rentalTransaction = new RentalTransaction(customerId, vehicleId, startDate, endDate)
            {
                Status = RentalStatus.Pending
            };

            _rentalTransactions.Add(rentalTransaction);
            await _vehicleService.UpdateVehicleAvailabilityAsync(vehicleId, false);

            return "Rental request created and is pending approval.";
        }

        public async Task<string> ApproveRentalRequestAsync(Guid rentalId, Guid employeeId)
        {
            var rentalTransaction = _rentalTransactions.FirstOrDefault(rt => rt.Id == rentalId);
            if (rentalTransaction == null)
            {
                return "Rental transaction not found.";
            }

            if (!await _userService.HasAccessAsync(employeeId, EmployeeRole.BackOffice))
            {
                return "Access denied. Only BackOffice employees can approve requests.";
            }

            rentalTransaction.Status = RentalStatus.Approved;
            return "Rental request approved.";
        }

        public async Task<string> DeclineRentalRequestAsync(Guid rentalId, Guid employeeId)
        {
            var rentalTransaction = _rentalTransactions.FirstOrDefault(rt => rt.Id == rentalId);
            if (rentalTransaction == null)
            {
                return "Rental transaction not found.";
            }

            if (!await _userService.HasAccessAsync(employeeId, EmployeeRole.BackOffice))
            {
                return "Access denied. Only BackOffice employees can decline requests.";
            }

            rentalTransaction.Status = RentalStatus.Declined;
            await _vehicleService.UpdateVehicleAvailabilityAsync(rentalTransaction.VehicleId, true);
            return "Rental request declined.";
        }

        public Task<RentalTransaction?> GetRentalTransactionByIdAsync(Guid id)
        {
            var rentalTransaction = _rentalTransactions.FirstOrDefault(rt => rt.Id == id);
            return Task.FromResult(rentalTransaction);
        }

        public Task<List<RentalTransaction>> GetPendingRentalRequestsAsync()
        {
            var pendingRequests = _rentalTransactions.Where(rt => rt.Status == RentalStatus.Pending).ToList();
            return Task.FromResult(pendingRequests);
        }

        public async Task<string> CancelRentalTransactionAsync(Guid rentalId)
        {
            var rentalTransaction = _rentalTransactions.FirstOrDefault(rt => rt.Id == rentalId);
            if (rentalTransaction == null)
            {
                return "Rental transaction not found.";
            }

            _rentalTransactions.Remove(rentalTransaction);
            await _vehicleService.UpdateVehicleAvailabilityAsync(rentalTransaction.VehicleId, true);
            return "Rental transaction canceled successfully.";
        }
    }