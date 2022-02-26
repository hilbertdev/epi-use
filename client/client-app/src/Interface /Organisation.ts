import IEmployee from '../Interface /Employee'

interface ParentChild {
    manager : IEmployee,
    children : Array<IEmployee>
}

export default ParentChild;