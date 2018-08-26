using API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using System;
using System.Linq;

namespace API.Controller
{
    [Route("v1/[controller]")]
    public class ProposalController : ControllerBase
    {
        private readonly IConferenceRepo conferenceRepo;
        private readonly IProposalRepo proposalRepo;

        public ProposalController(IConferenceRepo conferenceRepo, IProposalRepo proposalRepo)
        {
            this.conferenceRepo = conferenceRepo;
            this.proposalRepo = proposalRepo;
        }

        public IActionResult GetAll(int conferenceId)
        {
            var proposals = proposalRepo.GetAllForConference(conferenceId);

            if (!proposals.Any())
            {
                return new NoContentResult();
            }

            return new ObjectResult(proposals);
        }

        [HttpPost]
        public ProposalModel GetById(int id)
        {
            return proposalRepo.GetById(id);
        }

        [HttpPost]
        public IActionResult Add([FromBody]ProposalModel model)
        {
            var addedProposal = proposalRepo.Add(model);
            return CreatedAtRoute("GetById", new { id = addedProposal.Id }, addedProposal);
        }

        [HttpPut("{proposalId}")]
        public IActionResult Approve(int proposalId)
        {
            try
            {
                return new ObjectResult(proposalRepo.Approve(proposalId));
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
        }
    }
}
