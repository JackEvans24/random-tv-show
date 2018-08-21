# Random Tv Show

This app is designed to produce a random episode of a specified tv show.

The user can set a main directory to serve as the root for all their videos, and then select folders within that directory for the app to choose from. The user can select to "Autoplay" videos, which sets a timer for the length of the video. When the video ends, a new random video is played.
The second tab allows the user to select from a list of online shows, and clicking go opens a new browser tab containing a random episode taken from the selected shows.
Additionally, in the settings a user can set two folders as their shortcut folders. Once these shortcuts are set the user can press `Ctrl+1` or `Ctrl+2` to launch a random video from those folders. 


## App History

It came from a humble start of me wanting to watch Adventure Time again, but having seen all the episodes too many times to pick. I created a utility which worked solely with my file system to pick a video file from a hard-coded folder on my external hard drive.
From there I added the online utility, for when I didn't have my external hard drive to hand. The shows are stored in a static KeyValuePair array in the main .cs file of the app (quality architecture), and the app uses web scraping to retrieve all episodes of the selected show from the site I've used.
Shortcuts were next - `Ctrl+A` for a random Adventure Time episode and `Ctrl+R` for a random Regular Show episode. There were originally a number of other shortcuts which related to my external hard drive folder structure.

The main turning point of the app was when a friend came over, we used it to watch some cartoons, and he said he'd really like a copy. I knew I couldn't give it to him in that state as it would only work with my files, so I spent a few evenings refactoring, scrapping and rewriting code to make the app a lot more customisable. I had to add a settings tab, file/folder checks, null reference checks and some error handling for running in an external environment. I also changed the style of the app from basic WinForms to something closer to a marketable product.


## The future

I have a few features I'd like to add in the near future (most notably changing the *garbage* colour scheme) which each have an issue against them. Anything I'm working on or will be working on in future is stored there.
