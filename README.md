Speed up Play Mode with Editor Settings

Reduce waiting time when testing your game by changing how Unity reloads when entering Play Mode.

From the top menu, go to:
Edit → Project Settings → Editor

Under Enter Play Mode Settings, set the When entering Play Mode option to:
Do not reload Domain or Scene

Normally, Unity resets and reloads the entire project every time you press the Play button, which can take a few seconds.

By disabling domain and scene reloads, Unity skips this reset, allowing your game to enter Play Mode almost instantly.
This is a huge time-saver, especially during early development.

Experiment with Different Game View Resolutions

In the Game view, use the Aspect Ratio dropdown to try different screen resolutions.

You’ll notice that UI elements—such as the score text—may:

Change size

Shift position

Become harder to read at higher resolutions

Configure UI Scaling with Panel Settings
1. Select the Panel Settings Asset

In the Project window, locate the Panel Settings asset created when you added the UI Document to the scene.

It’s usually:

Inside a folder named UI Toolkit, or

Next to your UILayout asset

Tip: Use the search bar to search through the entire Assets folder.

2. Set Scaling to Match Screen Size

With the Panel Settings asset selected, open the Inspector and set:

Scale Mode → Scale With Screen Size

3. Adjust the Reference Resolution

If UI elements appear too small or too large, adjust the values under:

Scale Mode Parameters

Reference Resolution Width

Reference Resolution Height

After tweaking these values:

Test different aspect ratios from the Game view dropdown

Or resize the Game view by dragging its top edge

The score label should now remain anchored, readable, and consistent across all screen sizes.
