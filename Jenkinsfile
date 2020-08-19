 def app
pipeline {
    agent any
  tools {
        docker 'org.jenkinsci.plugins.docker.commons.tools.DockerTool'
    }
    stages {
        stage('build') {
            steps {
                  sh 'docker version'
            }
        }
    }
}
