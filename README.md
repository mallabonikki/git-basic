#### Setting up the git on commnad line
* git config --global user.name "mallabonikki"
* git config --global user.email "mallabonikki6678@gmail.com"
* git config --list
* git config --help
* git help config
* git add --help

#### Git Basic Commands
 * To Create new multiply feature and view it as ContentResult  
   * On the HomeController.cs:
        *	public ContentResult Multiply(int a, int b)
            {
                //return Content(a + "*" + b + " = " + a*b);
                return Content(string.Format("{0} * {1} = {2}", a, b, a*b));
            }
   * git status = It will show the untracked files
   * git diff = It will display the difference from the last changes
   * git add -A = add to staging area
     * To unstage files: git reset
   * git commit -m "Multiply two query parameters"
   * git branch -a = show all branches on local and remote repository.
   * git remote add origin <url> = create new repository from remote and the url
   * git pull origin master = pull the changes from the remote before pushing
   * git push origin master 
   * git branch -a = display all branches

#### Fixing Common Mistakes and Undoing Bad Commits
* git branch subtract-feature
* git branch = master
* Create a method Subract ContentResult in the HomeController wih thewrong statement
* git status = to see the changes that were made
* git diff = to see the wrong statement in the Subract Method
* git checkout <file want to reset> = to return to the last commit
* git diff = to see that there is no changes here now, back to the things that were made after the multiply commit
    * git add -A
    * git commit --amend = to include it to "Multiply two query parameter"
    * git log --stat = to see the last added files to this commit
* Create a method Subract ContentResuslt in the HomeController with the right subtract statement
* git status
* git commit -m "Completed Multiply Function" = which is wrong message
  * git add -A = just to stage the README.md
* git commit --amend -m "Completed Subract Fucntion" = to change the last commit message which is wrong a messaage
  * git log --stat = to see the last added files to this commit 

#### Fixing commits on the wrong branch by using cherry-pick
 * asume that we've already created subtract-feature branch
 * git branch = *master, subtract-feature
 * git log = HEAD~"Completed Subtract Function"
 * copy the commit hash
 * git checkout subtract-feature
 * git log = HEAD~"Multiply two query parameter"