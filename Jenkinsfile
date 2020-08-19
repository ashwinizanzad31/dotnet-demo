 def app
pipeline {
    agent any
  tools {
        docker 'docker-default'
    }
    stages {
        stage('build') {
            steps {
                  sh 'docker version'
            }
        }
    }
}
