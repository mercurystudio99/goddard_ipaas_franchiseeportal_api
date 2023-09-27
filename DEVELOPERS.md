# Development Process

Overview: This project is the API portion of the FBP Franchise Website. It generally follows the same API workflow as other GSL API Projects.

One interesting note is that the FBP Web project will point to the API for this environment.  E.g. FBP Web DEV points to FBP API DEV. While both of those projects will use the lower level API's in QA.  Therefore if you're making a change in a lower level API, e.g. content, the change will need to be pushed to the QA environment before it can be used by the FBP Projects.

## Branching Structure:
`latest`: Code that has been reviewed
`[feature|bug|task]/nnnnn-short-description`: a story, or bug, or task branch created to reflect the work done for the corresponding DevOps ticket.  E.g. `origin/feature/17482-default-duration-warning`
`develop`: Automatically deploys to the development environment.  It is the testing grounds for developers to try out code that they have written or that they want to show to other developers for review.
`qa`: Automatically deploys to the qa environment. This is the testing grounds for tickets that are going to either a QA role or UAT role to be verified for Acceptance Criteria and functionality.
`main`: This branch should reflect what is in production.  It is merged at the time of a release and is an ongoing log of `qa` builds that have been released to PROD.
`common`: This is a branch that typically deals with developer infrastructure, documentation, or other changes that either don't fit in a ticket, or - often - need to be merged into ongoing work in multiple, unrelated branches.

## Happy Path Development
1. Make a branch from your (bug|story|ticket)

### Bugs:
- Make a branch off of `main` with the `bug/nnnnn-short-description` branch format

### Stories:
- Make a branch off of `latest` with the `feature/nnnnn-short-description` branch format

## Tasks:
- [Optional]: Make a branch off of the `story` branch, *or* just work on the story branch directly. (Bigger tasks or spikes may warrant their own branch)

2. Code your feature on the branch.
    1. Anytime you want to test your code as a developer merge to `develop` to deploy the code to the development environment.
4. Submit a github PR to merge to `latest`
    1. Deal with any feedback until PR is approved or closed
5. Merge from Github into `latest`
6. Merge from `latest` into `qa` when ready to deploy for QA
