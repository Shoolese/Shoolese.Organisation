# Summary
- This is the 2nd major version of the personal organisation application I developed that I call "PFM"

# Solutions
| Solution Name                 | Purpose                                                                                                                                                           |
|-------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Shoolese.Organisation.DayPlan | DayPlan is intended as the root of the application; this is what I'll be interacting with on a daily basis                                                        |


# Projects By Solution
## Shoolese.Organisation.DayPlan
| Project Name                              | Purpose and Rules                                                                                                                                                 |
|-------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Shoolese.Organisation.DayPlan.Client      | This is where all the Forms logic _only_ will live. As well as the DI                                                                                             |
| Shoolese.Organisation.DayPlan.Core        | This is where all the logic is held; it should be _entirely_ stateless, extremely testable, should also contain the config                                        |
| Shoolese.Organisation.DayPlan.Domain      | This is where you'll store all the non-entity datatypes, as well as all the interfaces                                                                            |

# Rules
## Shoolese.Orgnaisation.DayPlan
- Each page should be built as it's own control in "Pages/*", name should be 1-1 with the tabs Text from the Home form, any children should obviously be in a shared controls folder if they're re-used.
