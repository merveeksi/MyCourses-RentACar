using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Context;
//using Persistence.Contexts;

namespace Persistence.Repositories;

public class EmailAuthenticatorRepository : EfRepositoryBase<EmailAuthenticator, int, BaseDbContext>, IEmailAuthenticatorRepository
{
    public EmailAuthenticatorRepository(BaseDbContext context)
        : base(context) { }
}