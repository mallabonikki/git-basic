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

