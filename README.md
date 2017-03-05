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