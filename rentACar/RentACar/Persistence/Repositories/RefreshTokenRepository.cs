using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
//using Persistence.Contexts;

namespace Persistence.Repositories;

public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, int, BaseDbContext>, IRefreshTokenRepository
{
    public RefreshTokenRepository(BaseDbContext context)
        : base(context) { }

    public async Task<List<RefreshToken>> GetOldRefreshTokensAsync(int userID, int refreshTokenTTL)
    {
        List<RefreshToken> tokens = await Query()
            .AsNoTracking()
            .Where(
                r =>
                    r.UserId == userID
                    && r.Revoked == null
                    && r.Expires >= DateTime.UtcNow
                    && r.CreatedDate.AddDays(refreshTokenTTL) <= DateTime.UtcNow //TTL Refresh Token ne kadar süreyle geçerli olacak
            )
            .ToListAsync();

        return tokens;
    }
}