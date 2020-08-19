 def app
pipeline {
    agent any
    stages {
        stage('build') {
            steps {
                  app = docker.build("getintodevops/hellonode")

            }
        }
    }
}
