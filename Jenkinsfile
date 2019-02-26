
pipeline{

    agent any

    stages{
        stage("Stage 1"){
            node {
                echo 'Pulling...' + env.BRANCH_NAME
            }
            steps{
                echo "Welcome "
            }
        }
    }
}