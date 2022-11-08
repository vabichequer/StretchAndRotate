# StretchAndRotate
A demonstration of stretch and rotation on a cube

![](Videos/demo.gif)

# How to build this project
This project was built using Unity 2020.1.6f1 and is untested in other versions, although it most likely would work with any recent version.

# Initial thoughts
I thought about implementing it by separating the rotation and stretching scripts because they perform different actions. Having them separated would ease on debugging and preserves modularity.

I have also taken care of the object hierarchy to keep it organized and reflect parent-child dependencies.

I included the shrinking function just because I thought it'd be cool and it took me less than a minute.

# How it works
Each interaction point will be represented by a rectangle, which corresponds to an axis, and allows stretching/shrinking. Each of them will be in a different color: X in red, Y in green and Z in blue.

By clicking on the grey cude and dragging, the whole cube will rotate.

# Shortcomings
- The code doesn't feature a highlight over which object is selected, which could be added for a better visual feedback.
- The code has no guards if an operation is already being performed. Therefore, if while rotating an interaction point is hit, the object will stretch.

