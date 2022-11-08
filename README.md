# StretchAndRotate
A demonstration of stretch and rotation on a cube

# How to build this project
This project was built using Unity 2020.1.6f1 and is untested in other versions, although it most likely would work with any recent version.

# Initial thoughts
I thought about implementing it by separating the rotation and stretching scripts because they perform different actions. Having them separated would ease on debugging and preserves modularity.

# Shortcomings
- The code doesn't feature a highlight over which object is selected, which could be added for a better visual feedback.
- The code has no guards if an operation is already being performed. Therefore, if while rotating an interaction point is hit, the object will stretch.

