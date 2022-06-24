pipeline{
  agent any
  stages{
    stage("build"){
      steps{
        echo "building the application..."
        bat "dotnet run 60"
      }
    }
    stage("test"){
      steps{
        echo 'testing the application...'
      }
    }
    stage("deploy"){
      steps{
        echo 'deploying the application...'
      }
    }
  }
}