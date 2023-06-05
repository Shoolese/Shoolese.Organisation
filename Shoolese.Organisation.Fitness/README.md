# Summary
- This sub-apps purpose is to tell me what exercises I should be doing on different days.

# Solutions
| Solution Name                               | Purpose                                                                                                                                                           |
|---------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Shoolese.Organisation.Fitness.Client        | Fitness.Client is intended as the root of the application; this is what I'll be interacting with on a daily                                                       |


# Projects By Solution
## Shoolese.Organisation.Fitness
| Project Name                              | Purpose and Rules                                                                                                                                                 |
|-------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Shoolese.Organisation.Fitness.Client      | This is where all the Forms logic _only_ will live. As well as the DI                                                                                             |
| Shoolese.Organisation.Fitness.Core        | This is where all the logic is held; it should be _entirely_ stateless, extremely testable, should also contain the config                                        |
| Shoolese.Organisation.Fitness.Domain      | This is where you'll store all the non-entity datatypes, as well as all the interfaces                                                                            |
| Shoolese.Organisation.Fitness.IoC         | This is where everything is plumbed into the DI container that is passed off to the client.                                                                       |

# Rules
## Shoolese.Organisation.Fitness
- Each page should be built as it's own control in "Pages/*", name should be 1-1 with the tabs Text from the Home form, any children should obviously be in a shared controls folder if they're re-used.
- Each sub-form should be kept seperate in /Sub-forms
- Each Sub-Form should have a Sub-Form Page in the /Pages/Sub-Form Pages folder
