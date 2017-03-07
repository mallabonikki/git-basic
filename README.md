1. Git Basic commands
 * git config --global user.name "mallabonikki"
 * git config --global user.email "mallabonikki6678@gmail.com"
 * git config --list
 * git config --help
 * git help config
 * git add --help
 
 * git init

 * Multiply query parameters and View it as ViewContent 
 * git status
 * git diff
 * git add -A = add to staging area
 * git reset = unstage all files that has been in stage area previously
 * git commit -m "Multiply query parameters and View it as ViewContent"
 * git branch -a
 * git remote add origin <url>
 * git pull origin master
 * git push origin master
 * git branch -a

2. Common Workflow
 * Create a branch for the desired feature
 * git branch calc-divide
 * git branch
 * git checkout calc-divide
 * git branch
 * Create ContentResult that can divides two numbers and view it as ViewContent
 * git status
 * git add -A
 * git commit -m "Divide ContentResult
 * git push -u origin calc-divide
 * git branch -a = to list all the branches
 * git checkout master = switched to master branch
 * git pull origin master = before commit anything to master it needs to pull out all changes from remote repository
 * git branch --merged = list all branch that has been merged
 * git merge calc-divide = it will merge all the changes in the master
 * git push origin master
 * git branch --merged = check if it is successfully merged
 * git branch -d calc-divide = calc-divide local repository should be disappeared
 * git branch -a = calc-divide branch should be disappeared
 * git push origin --delete calc-divide
 * git branch -a = calc-divide remote repository should be deleted
 
3. Fixing Common Mistakes and Undoing Bad Commits
 * branch is on master
 * create this guy: public ContentResult Subract(int a, int b)
                    {
                        return Content("");
                    }
 * git add -A
 * git commit -m "Initial Subract"
 * git status = Working tree clean
 * git log = Intial Subract (is the current HEAD)
 * git branch subract-feature = create new branch called subract-feature
 * modify this guy on the master branch: public ContentResult Subract(int a, int b)
                         {
                             return Content(String.Format("{0} - {1} = {2}", a ,b, a-b ));
                         }
 * git diff

 

 
  
  


 
  
