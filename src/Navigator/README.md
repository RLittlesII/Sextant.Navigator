# NavigatorState

This is likely the state as it is handled at the screen.

- Dependencies
  - `INavigator`

# INavigator

This is likely the platform specific implementation of a navigation service.

# Route<T>

This is the Route that can be called from the system.  It's generic type represents the ViewModel.

Use a Route<T> to construct a ViewModel of type T.
#### Responsibilities
- Construct a ViewModel
- Initialize a ViewModel
- Handle Events
  - NavigateTo
  - NavigateFrom
- Has a Query String
  - Name => Base Uri
  - Arguments => Query String
