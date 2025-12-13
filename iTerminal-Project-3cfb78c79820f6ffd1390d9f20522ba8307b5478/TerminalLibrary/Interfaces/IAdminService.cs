using System;
using System.Collections.Generic;
using TerminalLibrary.Models;

namespace TerminalLibrary.Interfaces
{
    // Interface për shërbimet administrative
    public interface IAdminService
    {
        DataTwo GetRegisteredRoutes();

        bool CheckRoute(Linja route);

        bool RegisterRoute(Linja route);

        PaginatedProductViewModel GetMyUnits(int userId, int page, int nisja);

        bool DeleteUnit(int UnitId, int UserId);

        DataTwo GetUnitAndLinja(int unitId);

        Unit GetUnitById(int UnitId);

        List<Linja> GetRoutes();
    }
}
