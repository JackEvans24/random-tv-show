## App History

The application came from a humble start of me wanting to watch Adventure Time again, but having seen all the episodes too many times have an unbiased opinion on which one to pick. I created a utility which only worked with my file system, picking a video file from a list of hard-coded folders on my external hard drive.

It didn't take me long to realise that finding and mounting my external hard drive every time I wanted to watch something was a bit of a pain. I have been using [WatchCartoonOnline](https://www.watchcartoononline.com/) to watch my favourite shows for years, so I decided to add the online utility. The site has a very rigid URL structure, with a combination of the base URL and the show name taking you to a list page of all the episodes they have on their site. Each link takes you to a different page, so it was fairly easy to use web scraping to retrieve links to all the episodes of a show and pick a random URL. The URL components for each show are stored in a static KeyValuePair array in the main .cs file of the app (which is top quality application architecture).

Shortcuts were the next thing I decided I needed to make my life 3 clicks easier - `Ctrl+A` for a random Adventure Time episode and `Ctrl+R` for a random Regular Show episode. There were originally a number of other shortcuts which related to my external hard drive folder structure.

The main turning point of the app was when a friend came over, we used it to watch some cartoons, and he said he'd really like a copy. I knew I couldn't give it to him in that state as it would only work with my files and instantly break on his PC, so I spent a few evenings refactoring, scrapping and rewriting code to make the app a lot more customisable. I had to add a settings tab so the user could set their root and shortcut folders, file/folder checks, null reference checks and a whole load of error handling for running in an external environment. I also changed the style of the app from basic WinForms rubbish to something closer to a marketable product.

Since turning the little utility into a full-blown application which works on other machines besides my own, I have added a number of features to make the app run smoothly, react to input and errors in a concise and informative way, and give the user what they want. The biggest change since the v1.0 release was the addition of the **Player** tab, which contains an embedded instance of Windows Media Player. This means that the application now knows how long the selected episode has been running for so that the autoplay feature is a lot cleaner than it used to be, and also that the user never has to leave the app to watch shows from their files.

I also added three app themes which change the colour of backgrounds and text, because I really hated the original light blue that I went for. Doing this was a real pain and a lot of repetitive, boring code, but the way in which I've coded it makes it easy for me to add more in future, so I'm pleased with that.


## The future

I have a few features I'd like to add in the near future which each have an issue against them. Anything I'm working on or will be working on in future is stored there, meaning the issues section is more of a bugs and features section.

I recently bought myself a Google ChromeCast and found out about a growing [ChromeCast SDK called SharpCaster](https://github.com/Tapanila/SharpCaster), which would be an awesome way to further my laziness - playing a random file on the tv rather than picking a random file, casting, finding the file... it would save at least 5 clicks.

I'd also like to do a little bit of work to make online videos play in the embedded player - this change shouldn't be that difficult to do and would make other changes I have in mind for further down the line (adding YouTube, Netflix, custom URL functionality) a little bit easier.